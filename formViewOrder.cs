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
    public partial class formViewOrder : Form
    {
        

        public formViewOrder()
        {
            InitializeComponent();
        }

        private void formViewOrder_Load(object sender, EventArgs e)
        {
            initList();
            listDetail.View = View.Details;
            labelOrders.Text = $"Number of Orders: {getTotalOders(Form1.loginRes)}";
            labelSpent.Text = $"Total Spent: ${getSpent(Form1.loginRes)}";
        }

    

        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDetail.Items.Clear();
            listDetail.Columns.Clear();
            getDetail(int.Parse(listOrders.SelectedItem.ToString()));
            labelTotal.Text = $"Order Total: $ {getTotal(int.Parse(listOrders.SelectedItem.ToString()))}";
        }

        private int getTotal(int Order)
        {
            int output = 0;
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT Total FROM Orders WHERE OrderNum = {Order};";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = int.Parse(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        private int getSpent(string Phone)
        {
            int output = 0;
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT SUM(Total) FROM Orders WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (string.IsNullOrEmpty(dataReader[0].ToString()))
                        return 0;
                    output = int.Parse(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        private int getTotalOders(string Phone)
        {
            int output = 0;
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT COUNT(*) FROM Orders WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = int.Parse(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
            return output;
        }

        private void getDetail(int Order)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                listDetail.Columns.Add("Items");
                listDetail.Columns.Add("Quantity");
                listDetail.Columns.Add("Unit Price");
                cn.Open();
                string tmp = $"SELECT ItemName, Quantity, Price FROM OrderDetail o left join Menu m ON o.SKU = m.SKU WHERE OrderNum = {Order};";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem lv = new ListViewItem(dataReader[0].ToString());
                    lv.SubItems.Add(dataReader[1].ToString());
                    lv.SubItems.Add(dataReader[2].ToString());
                    listDetail.Items.Add(lv);
                }
                listDetail.Columns[0].Width = -1;
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void initList()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"SELECT OrderNum FROM Orders WHERE Phone = '{Form1.loginRes}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    listOrders.Items.Add(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }
    }
}
