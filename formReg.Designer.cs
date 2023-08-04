namespace FinalProj
{
    partial class formReg
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
            this.textP2 = new System.Windows.Forms.TextBox();
            this.textP1 = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.textFirst = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textP2
            // 
            this.textP2.Location = new System.Drawing.Point(97, 65);
            this.textP2.Name = "textP2";
            this.textP2.Size = new System.Drawing.Size(175, 20);
            this.textP2.TabIndex = 0;
            this.textP2.UseSystemPasswordChar = true;
            // 
            // textP1
            // 
            this.textP1.Location = new System.Drawing.Point(97, 35);
            this.textP1.Name = "textP1";
            this.textP1.Size = new System.Drawing.Size(175, 20);
            this.textP1.TabIndex = 0;
            this.textP1.UseSystemPasswordChar = true;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(97, 6);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(175, 20);
            this.textID.TabIndex = 0;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(108, 172);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // textFirst
            // 
            this.textFirst.Location = new System.Drawing.Point(97, 105);
            this.textFirst.Name = "textFirst";
            this.textFirst.Size = new System.Drawing.Size(175, 20);
            this.textFirst.TabIndex = 2;
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(97, 131);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(175, 20);
            this.textLast.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verify Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "First name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last name:";
            // 
            // formReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 207);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textFirst);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textP1);
            this.Controls.Add(this.textP2);
            this.Name = "formReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textP2;
        private System.Windows.Forms.TextBox textP1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox textFirst;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}