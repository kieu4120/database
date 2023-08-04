namespace FinalProj
{
    partial class formAccount
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
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textP1 = new System.Windows.Forms.TextBox();
            this.textP2 = new System.Windows.Forms.TextBox();
            this.checkChange = new System.Windows.Forms.CheckBox();
            this.groupChange = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeP = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(92, 12);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(179, 20);
            this.textFName.TabIndex = 0;
            this.textFName.TextChanged += new System.EventHandler(this.textFName_TextChanged);
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(92, 39);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(179, 20);
            this.textLName.TabIndex = 1;
            this.textLName.TextChanged += new System.EventHandler(this.textLName_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(92, 66);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(179, 20);
            this.textPhone.TabIndex = 2;
            // 
            // textP1
            // 
            this.textP1.Location = new System.Drawing.Point(80, 19);
            this.textP1.Name = "textP1";
            this.textP1.Size = new System.Drawing.Size(179, 20);
            this.textP1.TabIndex = 3;
            this.textP1.UseSystemPasswordChar = true;
            // 
            // textP2
            // 
            this.textP2.Location = new System.Drawing.Point(80, 46);
            this.textP2.Name = "textP2";
            this.textP2.Size = new System.Drawing.Size(179, 20);
            this.textP2.TabIndex = 4;
            this.textP2.UseSystemPasswordChar = true;
            this.textP2.TextChanged += new System.EventHandler(this.textP2_TextChanged);
            // 
            // checkChange
            // 
            this.checkChange.AutoSize = true;
            this.checkChange.Location = new System.Drawing.Point(92, 90);
            this.checkChange.Name = "checkChange";
            this.checkChange.Size = new System.Drawing.Size(118, 17);
            this.checkChange.TabIndex = 5;
            this.checkChange.Text = "Change Password?";
            this.checkChange.UseVisualStyleBackColor = true;
            this.checkChange.CheckedChanged += new System.EventHandler(this.checkChange_CheckedChanged);
            // 
            // groupChange
            // 
            this.groupChange.Controls.Add(this.label5);
            this.groupChange.Controls.Add(this.label4);
            this.groupChange.Controls.Add(this.btnChangeP);
            this.groupChange.Controls.Add(this.textP1);
            this.groupChange.Controls.Add(this.textP2);
            this.groupChange.Location = new System.Drawing.Point(12, 113);
            this.groupChange.Name = "groupChange";
            this.groupChange.Size = new System.Drawing.Size(272, 110);
            this.groupChange.TabIndex = 6;
            this.groupChange.TabStop = false;
            this.groupChange.Text = "Change Password";
            this.groupChange.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Verify";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Password";
            // 
            // btnChangeP
            // 
            this.btnChangeP.Enabled = false;
            this.btnChangeP.Location = new System.Drawing.Point(71, 72);
            this.btnChangeP.Name = "btnChangeP";
            this.btnChangeP.Size = new System.Drawing.Size(105, 23);
            this.btnChangeP.TabIndex = 5;
            this.btnChangeP.Text = "Change Password";
            this.btnChangeP.UseVisualStyleBackColor = true;
            this.btnChangeP.Click += new System.EventHandler(this.btnChangeP_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(97, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone:";
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupChange);
            this.Controls.Add(this.checkChange);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Name = "formAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.formAccount_Load);
            this.groupChange.ResumeLayout(false);
            this.groupChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textP1;
        private System.Windows.Forms.TextBox textP2;
        private System.Windows.Forms.CheckBox checkChange;
        private System.Windows.Forms.GroupBox groupChange;
        private System.Windows.Forms.Button btnChangeP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}