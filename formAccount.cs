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
    public partial class formAccount : Form
    {

        static string Phone, AccType;
        public formAccount()
        {
            InitializeComponent();
        }

        private void checkChange_CheckedChanged(object sender, EventArgs e)
        {
            groupChange.Visible = !groupChange.Visible;
            textP1.Clear();
            textP2.Clear();
            btnSave.Visible = !btnSave.Visible;
        }

        private void formAccount_Load(object sender, EventArgs e)
        {
            Phone = Form1.loginRes;
            AccType = Form1.AccType;
            textPhone.Text = $"({Phone[0]}{Phone[1]}{Phone[2]}) {Phone[3]}{Phone[4]}{Phone[5]}-{Phone[6]}{Phone[7]}{Phone[8]}{Phone[9]}";
            if (AccType == "e")
            {
                textFName.Text = funcs.getEmpName(Phone, "Fname");
                textLName.Text = funcs.getEmpName(Phone, "Lname");
            } else
            {
                textFName.Text = funcs.getCusName(Phone, "Fname");
                textLName.Text = funcs.getCusName(Phone, "Lname");
            }
        }

        private void textP2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textP2.Text) && !string.IsNullOrEmpty(textP1.Text))
                btnChangeP.Enabled = true;
        }

        private void btnChangeP_Click(object sender, EventArgs e)
        {
            if (textP1.Text != textP2.Text)
            {
                MessageBox.Show("Passwords mismatch", "Error!");
                return;
            }
            else
            {
                // Update value
                funcs.updatePass(textP2.Text, Phone);
                MessageBox.Show("Password changed!", "Done");
                formAccount_Load(null, EventArgs.Empty);
                this.Close();
            }
        }

        private void textFName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textFName.Text) && !string.IsNullOrEmpty(textLName.Text))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void textLName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textFName.Text) && !string.IsNullOrEmpty(textLName.Text))
                btnSave.Enabled = true;
            else
                btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Form1.AccType == "e")
                funcs.updateEmpNames(textFName.Text, textLName.Text, Phone);
            else
                funcs.updateCusNames(textFName.Text, textLName.Text, Phone);
            MessageBox.Show("Changes saved!", "Done");
            formAccount_Load(null, EventArgs.Empty);
            this.Close();
        }
    }
}
