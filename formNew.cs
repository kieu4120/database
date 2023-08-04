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
    public partial class formNew : Form
    {
        static string curPrice, sub, curItem, SKU;
        int quant, total;

        public formNew()
        {
            InitializeComponent();
        }

        private void formNew_Load(object sender, EventArgs e)
        {
            initList();
            
        }


        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItem.SelectedIndex < 0)
                return;
            curPrice = funcs.getPrice(listItem.SelectedItem.ToString());
            labelPrice.Text = $"Item Price: $ {curPrice}";
            numericUpDown1.Value = 0;
            curItem = listItem.SelectedItem.ToString();
            SKU = funcs.getSKU(listItem.SelectedItem.ToString());
        }

        private void initList()
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = "SELECT ItemName FROM Menu;";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    listItem.Items.Add(dataReader.GetValue(0).ToString());
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listCart.Items.Count < 1)
            {
                MessageBox.Show("No items in cart", "Error");
                return;
            }
            int OrderNum = funcs.getLastOrder() + 1;
            funcs.addOrder(Form1.loginRes, OrderNum, total);
            foreach (var row in listCart.Items)
            {
                string[] output = row.ToString().Split(',');
                funcs.addOrderDetail(OrderNum, output[0], int.Parse(output[2]));
                // output[0]: SKU <-
                // output[1]: ItemName <-
                // output[2]: quantity <-
                // output[3]: sub total
            }
            MessageBox.Show("Order Received", "Success!");
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
                btnAdd.Enabled = false;
            else btnAdd.Enabled = true;
            sub = (numericUpDown1.Value * decimal.Parse(curPrice)).ToString();
            labelSub.Text = $"Sub: $ {sub}";
            quant = int.Parse(numericUpDown1.Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            total += int.Parse(sub);
            labelTot.Text = $"Total: $ {total}";
            listCart.Items.Add($"{SKU},{curItem},{quant},{sub}");
        }
    }
}
