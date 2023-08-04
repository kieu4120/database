namespace FinalProj
{
    partial class formManage
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
            this.listEmp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupNew = new System.Windows.Forms.GroupBox();
            this.btnNewEmp = new System.Windows.Forms.Button();
            this.textNewL = new System.Windows.Forms.TextBox();
            this.textNewF = new System.Windows.Forms.TextBox();
            this.textNewP2 = new System.Windows.Forms.TextBox();
            this.textNewP1 = new System.Windows.Forms.TextBox();
            this.textNewPhone = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.textP1 = new System.Windows.Forms.TextBox();
            this.textP2 = new System.Windows.Forms.TextBox();
            this.groupPw = new System.Windows.Forms.GroupBox();
            this.btnPw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkPw = new System.Windows.Forms.CheckBox();
            this.radE = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.btnReg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupNew.SuspendLayout();
            this.groupPw.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmp
            // 
            this.listEmp.FormattingEnabled = true;
            this.listEmp.Location = new System.Drawing.Point(16, 29);
            this.listEmp.Name = "listEmp";
            this.listEmp.Size = new System.Drawing.Size(150, 186);
            this.listEmp.TabIndex = 0;
            this.listEmp.SelectedIndexChanged += new System.EventHandler(this.listEmp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accounts:";
            // 
            // groupNew
            // 
            this.groupNew.Controls.Add(this.radM);
            this.groupNew.Controls.Add(this.radE);
            this.groupNew.Controls.Add(this.label7);
            this.groupNew.Controls.Add(this.label9);
            this.groupNew.Controls.Add(this.label8);
            this.groupNew.Controls.Add(this.label6);
            this.groupNew.Controls.Add(this.btnNewEmp);
            this.groupNew.Controls.Add(this.label5);
            this.groupNew.Controls.Add(this.textNewL);
            this.groupNew.Controls.Add(this.textNewF);
            this.groupNew.Controls.Add(this.textNewP2);
            this.groupNew.Controls.Add(this.textNewP1);
            this.groupNew.Controls.Add(this.textNewPhone);
            this.groupNew.Location = new System.Drawing.Point(472, 12);
            this.groupNew.Name = "groupNew";
            this.groupNew.Size = new System.Drawing.Size(259, 229);
            this.groupNew.TabIndex = 2;
            this.groupNew.TabStop = false;
            this.groupNew.Text = "New Employee";
            this.groupNew.Visible = false;
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Location = new System.Drawing.Point(93, 198);
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.Size = new System.Drawing.Size(75, 23);
            this.btnNewEmp.TabIndex = 5;
            this.btnNewEmp.Text = "Submit";
            this.btnNewEmp.UseVisualStyleBackColor = true;
            this.btnNewEmp.Click += new System.EventHandler(this.btnNewEmp_Click);
            // 
            // textNewL
            // 
            this.textNewL.Location = new System.Drawing.Point(128, 124);
            this.textNewL.Name = "textNewL";
            this.textNewL.Size = new System.Drawing.Size(125, 20);
            this.textNewL.TabIndex = 4;
            // 
            // textNewF
            // 
            this.textNewF.Location = new System.Drawing.Point(128, 97);
            this.textNewF.Name = "textNewF";
            this.textNewF.Size = new System.Drawing.Size(125, 20);
            this.textNewF.TabIndex = 3;
            // 
            // textNewP2
            // 
            this.textNewP2.Location = new System.Drawing.Point(128, 71);
            this.textNewP2.Name = "textNewP2";
            this.textNewP2.Size = new System.Drawing.Size(125, 20);
            this.textNewP2.TabIndex = 2;
            this.textNewP2.UseSystemPasswordChar = true;
            // 
            // textNewP1
            // 
            this.textNewP1.Location = new System.Drawing.Point(128, 45);
            this.textNewP1.Name = "textNewP1";
            this.textNewP1.Size = new System.Drawing.Size(125, 20);
            this.textNewP1.TabIndex = 1;
            this.textNewP1.UseSystemPasswordChar = true;
            // 
            // textNewPhone
            // 
            this.textNewPhone.Location = new System.Drawing.Point(128, 19);
            this.textNewPhone.Name = "textNewPhone";
            this.textNewPhone.Size = new System.Drawing.Size(125, 20);
            this.textNewPhone.TabIndex = 0;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(256, 29);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(129, 20);
            this.textPhone.TabIndex = 3;
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(256, 56);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(129, 20);
            this.textFirst.TabIndex = 4;
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(256, 83);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(129, 20);
            this.textLast.TabIndex = 5;
            // 
            // textP1
            // 
            this.textP1.Location = new System.Drawing.Point(108, 19);
            this.textP1.Name = "textP1";
            this.textP1.Size = new System.Drawing.Size(129, 20);
            this.textP1.TabIndex = 6;
            this.textP1.UseSystemPasswordChar = true;
            // 
            // textP2
            // 
            this.textP2.Location = new System.Drawing.Point(108, 45);
            this.textP2.Name = "textP2";
            this.textP2.Size = new System.Drawing.Size(129, 20);
            this.textP2.TabIndex = 7;
            this.textP2.UseSystemPasswordChar = true;
            // 
            // groupPw
            // 
            this.groupPw.Controls.Add(this.btnPw);
            this.groupPw.Controls.Add(this.textP1);
            this.groupPw.Controls.Add(this.textP2);
            this.groupPw.Controls.Add(this.label11);
            this.groupPw.Controls.Add(this.label10);
            this.groupPw.Location = new System.Drawing.Point(194, 132);
            this.groupPw.Name = "groupPw";
            this.groupPw.Size = new System.Drawing.Size(243, 109);
            this.groupPw.TabIndex = 8;
            this.groupPw.TabStop = false;
            this.groupPw.Text = "Password";
            this.groupPw.Visible = false;
            // 
            // btnPw
            // 
            this.btnPw.Location = new System.Drawing.Point(108, 71);
            this.btnPw.Name = "btnPw";
            this.btnPw.Size = new System.Drawing.Size(75, 23);
            this.btnPw.TabIndex = 8;
            this.btnPw.Text = "Submit";
            this.btnPw.UseVisualStyleBackColor = true;
            this.btnPw.Click += new System.EventHandler(this.btnPw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone numer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Last name:";
            // 
            // checkPw
            // 
            this.checkPw.AutoSize = true;
            this.checkPw.Location = new System.Drawing.Point(194, 109);
            this.checkPw.Name = "checkPw";
            this.checkPw.Size = new System.Drawing.Size(112, 17);
            this.checkPw.TabIndex = 15;
            this.checkPw.Text = "Change Password";
            this.checkPw.UseVisualStyleBackColor = true;
            this.checkPw.Visible = false;
            this.checkPw.CheckedChanged += new System.EventHandler(this.checkPw_CheckedChanged);
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Location = new System.Drawing.Point(128, 151);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(71, 17);
            this.radE.TabIndex = 6;
            this.radE.TabStop = true;
            this.radE.Text = "Employee";
            this.radE.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(128, 175);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(67, 17);
            this.radM.TabIndex = 7;
            this.radM.TabStop = true;
            this.radM.Text = "Manager";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(16, 218);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(150, 23);
            this.btnReg.TabIndex = 16;
            this.btnReg.Text = "Add new employee";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone numer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "First name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Verify:";
            // 
            // btnFire
            // 
            this.btnFire.Enabled = false;
            this.btnFire.Location = new System.Drawing.Point(391, 80);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 17;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Verify:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(256, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 13);
            this.labelTitle.TabIndex = 18;
            // 
            // formManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 249);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.checkPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPw);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.groupNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEmp);
            this.Name = "formManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.formManage_Load);
            this.groupNew.ResumeLayout(false);
            this.groupNew.PerformLayout();
            this.groupPw.ResumeLayout(false);
            this.groupPw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupNew;
        private System.Windows.Forms.Button btnNewEmp;
        private System.Windows.Forms.TextBox textNewL;
        private System.Windows.Forms.TextBox textNewF;
        private System.Windows.Forms.TextBox textNewP2;
        private System.Windows.Forms.TextBox textNewP1;
        private System.Windows.Forms.TextBox textNewPhone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.TextBox textP1;
        private System.Windows.Forms.TextBox textP2;
        private System.Windows.Forms.GroupBox groupPw;
        private System.Windows.Forms.Button btnPw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.RadioButton radE;
        private System.Windows.Forms.CheckBox checkPw;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTitle;
    }
}