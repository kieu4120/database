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
    public partial class formReg : Form
    {
        public formReg()
        {
            InitializeComponent();
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textP2.Text) || String.IsNullOrEmpty(textP1.Text) || String.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Required fields are empty", "Error!");
                return;
            } // verify if boxes are empty
            if (textID.Text.Length != 10)
            {
                MessageBox.Show($"Phone number needs to have 10 digits, yours has {textID.Text.Length}", "Error");
                return;
            } // verify if phone has 10 chars
            if (!long.TryParse(textID.Text, out long tempRes))
            {
                MessageBox.Show("Phone number needs to be numeric", "Error");
                return;
            } // verify if phone is numeric
            if (textP1.Text != textP2.Text)
            {
                MessageBox.Show("Password mismatch", "Error!");
                textP1.Clear();
                textP2.Clear();
                return;
            } // verify if passwords are same

            if (!funcs.verifyPhone(textID.Text))
            {
                MessageBox.Show("Account existed for this phone number", "Error");
                return;
            } // Check duplicate username

            string Phone = textID.Text, Pass = textP2.Text, fName, lName;
            if (String.IsNullOrEmpty(textFirst.Text))
                fName = "NA";
            else
                fName = textFirst.Text;
            if (String.IsNullOrEmpty(textLast.Text))
                lName = "NA";
            else
                lName = textLast.Text;
            // Code when everything checks out
            // HERE
            // 
            funcs.newAccount(Phone, Pass, fName, lName);
            MessageBox.Show("Registration success!", "Welcome");
            this.Close();
        }

    }
}
