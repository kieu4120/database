namespace FinalProj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textID = new System.Windows.Forms.TextBox();
            this.textPw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.grpDashboard = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtTier = new System.Windows.Forms.Label();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpLogin.SuspendLayout();
            this.grpDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(66, 19);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(154, 20);
            this.textID.TabIndex = 0;
            // 
            // textPw
            // 
            this.textPw.Location = new System.Drawing.Point(66, 45);
            this.textPw.Name = "textPw";
            this.textPw.Size = new System.Drawing.Size(154, 20);
            this.textPw.TabIndex = 0;
            this.textPw.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(66, 71);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.btnReg);
            this.grpLogin.Controls.Add(this.textID);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.textPw);
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(240, 147);
            this.grpLogin.TabIndex = 2;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone:";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(145, 71);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // grpDashboard
            // 
            this.grpDashboard.Controls.Add(this.btnReport);
            this.grpDashboard.Controls.Add(this.btnManage);
            this.grpDashboard.Controls.Add(this.btnLogout);
            this.grpDashboard.Controls.Add(this.txtTier);
            this.grpDashboard.Controls.Add(this.txtWelcome);
            this.grpDashboard.Controls.Add(this.btnNew);
            this.grpDashboard.Controls.Add(this.btnOrder);
            this.grpDashboard.Controls.Add(this.btnAcc);
            this.grpDashboard.Location = new System.Drawing.Point(6, 6);
            this.grpDashboard.Name = "grpDashboard";
            this.grpDashboard.Size = new System.Drawing.Size(252, 161);
            this.grpDashboard.TabIndex = 3;
            this.grpDashboard.TabStop = false;
            this.grpDashboard.Text = "Dashboard";
            this.grpDashboard.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(171, 124);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtTier
            // 
            this.txtTier.AutoSize = true;
            this.txtTier.Location = new System.Drawing.Point(7, 38);
            this.txtTier.Name = "txtTier";
            this.txtTier.Size = new System.Drawing.Size(68, 13);
            this.txtTier.TabIndex = 6;
            this.txtTier.Text = "Current Tier: ";
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Location = new System.Drawing.Point(6, 19);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(85, 13);
            this.txtWelcome.TabIndex = 5;
            this.txtWelcome.Text = "Welcome back, ";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 125);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Order";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(6, 95);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(124, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "View Orders";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(6, 66);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(126, 23);
            this.btnAcc.TabIndex = 3;
            this.btnAcc.Text = "Account Information";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(138, 66);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(108, 23);
            this.btnManage.TabIndex = 8;
            this.btnManage.Text = "Manage Employees";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(138, 95);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(108, 23);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Shop Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 171);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.grpDashboard);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USF Boba";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpDashboard.ResumeLayout(false);
            this.grpDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.GroupBox grpDashboard;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Label txtTier;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnReport;
    }
}

