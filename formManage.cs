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
    public partial class formManage : Form
    {
        public formManage()
        {
            InitializeComponent();
        }

        private void formManage_Load(object sender, EventArgs e)
        {
            // full size: 756, 288
            // normal size: 488, 288
            this.Size = new Size(488, 288);
            listEmp.Items.Clear();
            checkPw.Checked = false;
            textFirst.Clear();
            textLast.Clear();
            textPhone.Clear();
            btnFire.Enabled = false;
            btnSave.Enabled = false;
            btnReg.Text = "Add new employee";
            labelTitle.Text = "";
            radE.Checked = true;
            initList(Form1.Pos);
            if (Form1.Pos == "o")
            {
                radM.Enabled = true;
            } else if (Form1.Pos == "m")
            {
                radM.Enabled = false;
            }
        }

        private void checkPw_CheckedChanged(object sender, EventArgs e)
        {
            groupPw.Visible = !groupPw.Visible;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            groupNew.Visible = !groupNew.Visible;
            textNewF.Clear();
            textNewL.Clear();
            textNewP1.Clear();
            textNewP2.Clear();
            textNewPhone.Clear();
            if (groupNew.Visible == true)
            {
                this.Size = new Size(756, 288);
                btnReg.Text = "Cancel";
            } else
            {
                this.Size = new Size(488, 288);
                btnReg.Text = "Add new employee";
            }
        }

        private void initList (string Pos)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp;
                if (Pos == "o")
                    tmp = $"SELECT * FROM Employees WHERE Pos = 'm' OR Pos = 'e';";
                else
                    tmp = $"SELECT * FROM Employees WHERE Pos = 'e';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    listEmp.Items.Add($"{dataReader.GetValue(1)} {dataReader.GetValue(2)},{dataReader[0]}");
                }
                dataReader.Close(); // close after reading
                cn.Close();
            }
        }

        private void listEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmp.SelectedIndex < 0)
                return;
            btnSave.Enabled = true;

            string Phone = listEmp.SelectedItem.ToString().Split(',')[1];
            if (funcs.getPos(Phone) == "m")
                labelTitle.Text = "Manager";
            else if (funcs.getPos(Phone) == "o")
                labelTitle.Text = "Owner";
            else labelTitle.Text = "Employee";
            textPhone.Text = $"({Phone[0]}{Phone[1]}{Phone[2]}) {Phone[3]}{Phone[4]}{Phone[5]}-{Phone[6]}{Phone[7]}{Phone[8]}{Phone[9]}";
            textFirst.Text = funcs.getEmpName(Phone, "Fname");
            textLast.Text = funcs.getEmpName(Phone, "Lname");
            if (!string.IsNullOrEmpty(textPhone.Text))
            {
                btnFire.Enabled = true;
                checkPw.Visible = true;
            }
            else
            {
                btnFire.Enabled = false;
                checkPw.Visible = false;
            }
        }

        private void fireEmp (String Phone)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"DELETE FROM Employees WHERE Phone = '{Phone}';DELETE FROM Account WHERE Phone = '{Phone}';";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            DialogResult verify = MessageBox.Show("Are you sure to fire this employee?", "Warning", MessageBoxButtons.YesNo);
            if (verify == DialogResult.Yes)
            {
                fireEmp(listEmp.SelectedItem.ToString().Split(',')[1]);
                MessageBox.Show("Employee fired!", "RIP");
                formManage_Load(null, EventArgs.Empty);
            } else
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listEmp.SelectedIndex < 0)
            {
                MessageBox.Show("No Employee Selected");
                return;
            }
            funcs.updateEmpNames(textFirst.Text, textLast.Text, listEmp.SelectedItem.ToString().Split(',')[1]);
            MessageBox.Show("Changes saved!", "Done");
            formManage_Load(null, EventArgs.Empty);
        }

        private void btnPw_Click(object sender, EventArgs e)
        {
            if (textP1.Text != textP2.Text)
            {
                MessageBox.Show("Passwords mismatch", "Error!");
                return;
            }
            else
            {
                // Update value
                funcs.updatePass(textP2.Text, listEmp.SelectedItem.ToString().Split(',')[1]);
                MessageBox.Show("Password changed!", "Done");
                checkPw.Checked = false;
            }
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textNewP2.Text) || String.IsNullOrEmpty(textNewP1.Text) || String.IsNullOrEmpty(textNewPhone.Text))
            {
                MessageBox.Show("Required fields are empty", "Error!");
                return;
            } // verify if boxes are empty
            if (textNewPhone.Text.Length != 10)
            {
                MessageBox.Show($"Phone number needs to have 10 digits, yours has {textNewPhone.Text.Length}", "Error");
                return;
            } // verify if phone has 10 chars
            if (!long.TryParse(textNewPhone.Text, out long tempRes))
            {
                MessageBox.Show("Phone number needs to be numeric", "Error");
                return;
            } // verify if phone is numeric
            if (textNewP2.Text != textNewP1.Text)
            {
                MessageBox.Show("Password mismatch", "Error!");
                textNewP1.Clear();
                textNewP2.Clear();
                return;
            } // verify if passwords are same

            if (!funcs.verifyPhone(textNewPhone.Text))
            {
                MessageBox.Show("Account existed for this phone number", "Error");
                return;
            } // Check duplicate username

            string Phone = textNewPhone.Text, Pass = textNewP2.Text, fName, lName, Pos = "e";
            if (String.IsNullOrEmpty(textNewF.Text))
                fName = "NA";
            else
                fName = textNewF.Text;
            if (String.IsNullOrEmpty(textNewL.Text))
                lName = "NA";
            else
                lName = textNewL.Text;
            if (radE.Checked)
                Pos = "e";
            else if (radM.Checked)
                Pos = "m";
            newAccount(Phone, Pass, fName, lName, Pos);
            MessageBox.Show("New employee added", "Done");
            formManage_Load(null, EventArgs.Empty);
        }

        private void newAccount(string Phone, string Pass, string fName, string lName, string Pos)
        {
            var cns = ConfigurationManager.ConnectionStrings["localMSSQL"].ConnectionString;
            using (var cn = new SqlConnection(cns))
            {
                cn.Open();
                string tmp = $"INSERT INTO Account VALUES ('{Phone}','{Pass}','e');INSERT INTO Employees VALUES ('{Phone}', '{fName}', '{lName}','{Pos}');";
                var command = new SqlCommand(tmp, cn);
                var dataReader = command.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
