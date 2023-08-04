namespace FinalProj
{
    partial class formViewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.listDetail = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSpent = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders #:";
            // 
            // listOrders
            // 
            this.listOrders.FormattingEnabled = true;
            this.listOrders.Location = new System.Drawing.Point(12, 25);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(120, 147);
            this.listOrders.TabIndex = 2;
            this.listOrders.SelectedIndexChanged += new System.EventHandler(this.listOrders_SelectedIndexChanged);
            // 
            // listDetail
            // 
            this.listDetail.HideSelection = false;
            this.listDetail.Location = new System.Drawing.Point(138, 25);
            this.listDetail.Name = "listDetail";
            this.listDetail.Size = new System.Drawing.Size(335, 147);
            this.listDetail.TabIndex = 3;
            this.listDetail.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Detail:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(260, 179);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(97, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Order Total: $ 0";
            // 
            // labelSpent
            // 
            this.labelSpent.AutoSize = true;
            this.labelSpent.Location = new System.Drawing.Point(12, 202);
            this.labelSpent.Name = "labelSpent";
            this.labelSpent.Size = new System.Drawing.Size(80, 13);
            this.labelSpent.TabIndex = 6;
            this.labelSpent.Text = "Total Spent: $0";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Location = new System.Drawing.Point(12, 179);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(93, 13);
            this.labelOrders.TabIndex = 7;
            this.labelOrders.Text = "Number of Orders:";
            // 
            // formViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 230);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.labelSpent);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listDetail);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.label1);
            this.Name = "formViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.formViewOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.ListView listDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSpent;
        private System.Windows.Forms.Label labelOrders;
    }
}