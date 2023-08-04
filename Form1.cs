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
    public partial class Form1 : Form
    {
        public static string loginRes, AccType, Pos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if boxes are empty
            if (String.IsNullOrEmpty(textID.Text) || String.IsNullOrEmpty(textPw.Text))
            {
                MessageBox.Show("Required fields are empty", "Error");
                return;
            }
            // Check inputs for login
            loginRes = funcs.tryLogin(textID.Text, textPw.Text);
            if (loginRes == "flag")
            {
                MessageBox.Show("Phone number and password mismatch", "Login Failed");
                return;
            }
            else
            {
                // Default size: 280, 210
                if (AccType == "e")
                {
                    grpLogin.Visible = false;
                    grpDashboard.Visible = true;
                    textID.Clear();
                    textPw.Clear();
                    txtWelcome.Text = $"Welcome back, {funcs.getEmpName(loginRes, "Fname")}!";
                    Pos = funcs.getPos(loginRes);
                    if (Pos == "o")
                    {
                        txtTier.Text = $"Position: Owner";
                        btnReport.Visible = true;
                        btnReport.Enabled = true;
                        btnManage.Visible = true;
                        btnManage.Enabled = true;
                        btnNew.Enabled = false;
                        btnOrder.Enabled = false;
                    }
                    else if (Pos == "m")
                    {
                        txtTier.Text = $"Position: Manager";
                        btnReport.Visible = true;
                        btnReport.Enabled = false;
                        btnManage.Visible = true;
                        btnManage.Enabled = true;
                        btnNew.Enabled = false;
                        btnOrder.Enabled = false;
                    }
                    else if (Pos == "e")
                    {
                        txtTier.Text = $"Position: Employee";
                        btnReport.Visible = true;
                        btnReport.Enabled = false;
                        btnManage.Visible = true;
                        btnManage.Enabled = false;
                        btnNew.Enabled = false;
                        btnOrder.Enabled = false;
                    }
                    
                }
                else
                {
                    btnReport.Visible = false;
                    btnReport.Enabled = false;
                    btnManage.Visible = false;
                    btnManage.Enabled = false;
                    btnNew.Enabled = true;
                    btnOrder.Enabled = true;
                    grpLogin.Visible = false;
                    grpDashboard.Visible = true;
                    textID.Clear();
                    textPw.Clear();
                    txtWelcome.Text = $"Welcome back, {funcs.getCusName(loginRes, "Fname")}!";
                    txtTier.Text = $"Current Tier: {funcs.getTier(loginRes)}";
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var formReg = new formReg();
            formReg.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtTier.Text = "Current tier: ";
            txtWelcome.Text = "Welcome back, ";
            grpDashboard.Visible = false;
            grpLogin.Visible = true;
            loginRes = "";
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            var formAccount = new formAccount();
            formAccount.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var formViewOrder = new formViewOrder();
            formViewOrder.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            var formManage = new formManage();
            formManage.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var formReport = new formReport();
            formReport.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var formNew = new formNew();
            formNew.ShowDialog();
        }
    }
}
