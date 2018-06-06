namespace TRPZ_project
{
    partial class TransactionHistoryForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnCreateReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 420);
            this.listBox1.TabIndex = 0;
            // 
            // BtnCreateReceipt
            // 
            this.BtnCreateReceipt.Location = new System.Drawing.Point(13, 444);
            this.BtnCreateReceipt.Name = "BtnCreateReceipt";
            this.BtnCreateReceipt.Size = new System.Drawing.Size(344, 23);
            this.BtnCreateReceipt.TabIndex = 1;
            this.BtnCreateReceipt.Text = "Створити чек";
            this.BtnCreateReceipt.UseVisualStyleBackColor = true;
            this.BtnCreateReceipt.Click += new System.EventHandler(this.BtnCreateReceipt_Click);
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 478);
            this.Controls.Add(this.BtnCreateReceipt);
            this.Controls.Add(this.listBox1);
            this.Name = "TransactionHistoryForm";
            this.Text = "Історія транзакцій";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnCreateReceipt;
    }
}