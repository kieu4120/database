using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProj
{
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            initList();
            initTable();
        }

        private void initTable()
        {
            label1.Text = "";
            listReport.Items.Clear();
            listReport.Columns.Clear();
        }
        private void initList()
        {
            listReport.View = View.Details;
            comboSel.Items.Clear();
            comboSel.Items.Add("Total Revenue");
            comboSel.Items.Add("Revenue by Month");
            comboSel.Items.Add("Total Drinks sold");
            comboSel.Items.Add("Drinks sold by Month");
            comboSel.Items.Add("Orders sold");
            comboSel.Items.Add("Orders sold by Month");
            comboSel.Items.Add("5 Best Sellers");
            comboSel.Items.Add("Customers Report");
        }

        private void comboSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            initTable();
            switch (comboSel.SelectedIndex)
            {
                case 0:
                    reportRevAll();
                    getAllOrders();
                    MessageBox.Show(label1.Text, "Report");
                    break;
                case 1:
                    reportRevMonth();
                    break;
                case 2:
                    reportDrinkAll();
                    getAllDetail();
                    MessageBox.Show(label1.Text, "Report");
                    break;
                case 3:
                    reportDrinkMonth();
                    break;
                case 4:
                    reportOrdersAll();
                    getAllOrders();
                    MessageBox.Show(label1.Text, "Report");
                    break;
                case 5:
                    reportOrdersMonth();
                    break;
                case 6:
                    reportBestSeller();
                    break;
                case 7:
                    reportCustomers();
                    break;
                default:
                    break;
            }
        }

        private void reportRevAll()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = "SELECT SUM(Total) FROM Orders;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    label1.Text = $"Total Revenue: ${dataReader[0]}";
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void getAllOrders()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("Order Number");
                listReport.Columns.Add("Total");
                listReport.Columns.Add("Order Time");
                cn.Open();
                string tmp = "SELECT OrderNum, Total, OrderTime FROM Orders;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add($"${dataReader[1]}");
                    lv.SubItems.Add(dataReader[2].ToString());
                    listReport.Items.Add(lv);
                }
                listReport.Columns[0].Width = -2;
                listReport.Columns[2].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }


        private void getAllDetail()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("Order Number");
                listReport.Columns.Add("Item");
                listReport.Columns.Add("Quantity");
                cn.Open();
                string tmp = "SELECT OrderNum, ItemName, Quantity FROM OrderDetail o LEFT JOIN Menu m ON o.SKU = m.SKU ORDER BY OrderNum;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add(dataReader[1].ToString());
                    lv.SubItems.Add(dataReader[2].ToString());
                    listReport.Items.Add(lv);
                }
                listReport.Columns[0].Width = -2;
                listReport.Columns[1].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportRevMonth()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("Year");
                listReport.Columns.Add("Month");
                listReport.Columns.Add("Total");
                cn.Open();
                string tmp = "SELECT DATENAME(year, OrderTime) as Y, DATENAME(month, OrderTime) as M, SUM(Total) AS Total, Year(OrderTime) AS Year, Month(OrderTime) AS Month FROM Orders GROUP BY DATENAME(month, OrderTime),DATENAME(year, OrderTime), Month(OrderTime), Year(OrderTime) ORDER BY Month(OrderTime), Year(OrderTime);";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add(dataReader[1].ToString());
                    lv.SubItems.Add($"${dataReader[2]}");
                    listReport.Items.Add(lv);
                }
                reportRevAll();
                //listReport.Columns[0].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportDrinkAll()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = "SELECT SUM(Quantity) FROM OrderDetail;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    label1.Text = $"Total Drinks Sold: {dataReader[0]}";
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportDrinkMonth()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("Year");
                listReport.Columns.Add("Month");
                listReport.Columns.Add("Drinks Sold", -2);
                cn.Open();
                string tmp = "SELECT DATENAME(year, OrderTime) as Y, DATENAME(month, OrderTime) as M, SUM(Quantity) AS Sold, Year(OrderTime) AS Year, Month(OrderTime) AS Month  FROM Orders o, OrderDetail d WHERE o.OrderNum = d.OrderNum GROUP BY DATENAME(month, OrderTime),DATENAME(year, OrderTime), Month(OrderTime), Year(OrderTime) ORDER BY Month(OrderTime), Year(OrderTime);";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add(dataReader[1].ToString());
                    lv.SubItems.Add(dataReader[2].ToString());
                    listReport.Items.Add(lv);
                }
                reportDrinkAll();
                //listReport.Columns[0].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportOrdersAll()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = "SELECT COUNT(*) FROM Orders;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    label1.Text = $"Total Orders Sold: {dataReader[0]}";
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportOrdersMonth()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("Year");
                listReport.Columns.Add("Month");
                listReport.Columns.Add("Orders Sold", -2);
                cn.Open();
                string tmp = "SELECT DATENAME(year, OrderTime) as Y, DATENAME(month, OrderTime) as M, COUNT(*) AS Orders, Year(OrderTime) AS Year, Month(OrderTime) AS Month FROM Orders GROUP BY DATENAME(month, OrderTime),DATENAME(year, OrderTime), Month(OrderTime), Year(OrderTime) ORDER BY Month(OrderTime), Year(OrderTime);";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add(dataReader[1].ToString());
                    lv.SubItems.Add(dataReader[2].ToString());
                    listReport.Items.Add(lv);
                }
                reportOrdersAll();
                //listReport.Columns[0].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportBestSeller()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("SKU");
                listReport.Columns.Add("Item");
                listReport.Columns.Add("Sold");
                cn.Open();
                string tmp = "select g.SKU, ItemName, sold from (select TOP 5  SKU, SUM(Quantity) as sold FROM OrderDetail GROUP BY SKU ORDER BY sold DESC) g left join Menu m ON g.SKU = m.SKU ORDER BY sold DESC;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add(dataReader[1].ToString());
                    lv.SubItems.Add(dataReader[2].ToString());
                    listReport.Items.Add(lv);
                }
                listReport.Columns[1].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void reportCustomers()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listReport.Columns.Add("Name");
                listReport.Columns.Add("Orders");
                listReport.Columns.Add("Spent");
                listReport.Columns.Add("Phone");
                listReport.Columns.Add("Tier");
                cn.Open();
                string tmp = "SELECT Fname, Lname, Orders, Point, xx.Phone, Tier  FROM (SELECT x.Phone, x.Rank, COUNT(*) AS Orders FROM (SELECT Phone, MAX(Milestone) AS Rank FROM Points p join CustomerTier ct ON p.Point >= ct.Milestone GROUP BY p.Phone) x LEFT JOIN Orders o ON x.Phone = o.Phone GROUP BY x.Phone, x.Rank ) xx LEFT JOIN CustomerTier y ON xx.Rank = y.Milestone LEFT JOIN Customers c ON xx.Phone = c.Phone LEFT JOIN Points pt ON xx.Phone = pt.Phone ORDER BY Point DESC;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem($"{dataReader[0]} {dataReader[1]}");
                    lv.SubItems.Add(dataReader[2].ToString());
                    lv.SubItems.Add($"${dataReader[3]}");
                    lv.SubItems.Add(dataReader[4].ToString());
                    lv.SubItems.Add(dataReader[5].ToString());
                    listReport.Items.Add(lv);
                }
                listReport.Columns[0].Width = -1;
                listReport.Columns[3].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }
    }
}
