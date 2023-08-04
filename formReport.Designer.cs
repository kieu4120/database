namespace FinalProj
{
    partial class formReport
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
            this.comboSel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listReport = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // comboSel
            // 
            this.comboSel.FormattingEnabled = true;
            this.comboSel.Location = new System.Drawing.Point(12, 12);
            this.comboSel.Name = "comboSel";
            this.comboSel.Size = new System.Drawing.Size(333, 21);
            this.comboSel.TabIndex = 10;
            this.comboSel.SelectedIndexChanged += new System.EventHandler(this.comboSel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // listReport
            // 
            this.listReport.HideSelection = false;
            this.listReport.Location = new System.Drawing.Point(12, 39);
            this.listReport.Name = "listReport";
            this.listReport.Size = new System.Drawing.Size(667, 460);
            this.listReport.TabIndex = 13;
            this.listReport.UseCompatibleStateImageBehavior = false;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 511);
            this.Controls.Add(this.listReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSel);
            this.Name = "formReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Report";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listReport;
    }
}