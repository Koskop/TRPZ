namespace TRPZ_project
{
    partial class MainForm
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
            this.LabelClientMainData = new System.Windows.Forms.Label();
            this.LabelWorkerName = new System.Windows.Forms.Label();
            this.TextBoxClientData = new System.Windows.Forms.TextBox();
            this.ButtonFindClient = new System.Windows.Forms.Button();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ButtonTransactionHistory = new System.Windows.Forms.Button();
            this.LabelFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelClientMainData
            // 
            this.LabelClientMainData.AutoSize = true;
            this.LabelClientMainData.Location = new System.Drawing.Point(13, 16);
            this.LabelClientMainData.Name = "LabelClientMainData";
            this.LabelClientMainData.Size = new System.Drawing.Size(135, 13);
            this.LabelClientMainData.TabIndex = 1;
            this.LabelClientMainData.Text = "Серія та номер паспорту:";
            // 
            // LabelWorkerName
            // 
            this.LabelWorkerName.AutoSize = true;
            this.LabelWorkerName.Location = new System.Drawing.Point(629, 17);
            this.LabelWorkerName.Name = "LabelWorkerName";
            this.LabelWorkerName.Size = new System.Drawing.Size(70, 13);
            this.LabelWorkerName.TabIndex = 2;
            this.LabelWorkerName.Text = "WorkerName";
            this.LabelWorkerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxClientData
            // 
            this.TextBoxClientData.Location = new System.Drawing.Point(154, 13);
            this.TextBoxClientData.Name = "TextBoxClientData";
            this.TextBoxClientData.Size = new System.Drawing.Size(137, 20);
            this.TextBoxClientData.TabIndex = 3;
            this.TextBoxClientData.Text = "KO444444";
            // 
            // ButtonFindClient
            // 
            this.ButtonFindClient.Location = new System.Drawing.Point(299, 12);
            this.ButtonFindClient.Name = "ButtonFindClient";
            this.ButtonFindClient.Size = new System.Drawing.Size(75, 23);
            this.ButtonFindClient.TabIndex = 4;
            this.ButtonFindClient.Text = "Пошук";
            this.ButtonFindClient.UseVisualStyleBackColor = true;
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Location = new System.Drawing.Point(498, 11);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(125, 23);
            this.ButtonAddClient.TabIndex = 5;
            this.ButtonAddClient.Text = "Додати клієнта";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // ButtonTransactionHistory
            // 
            this.ButtonTransactionHistory.Location = new System.Drawing.Point(380, 12);
            this.ButtonTransactionHistory.Name = "ButtonTransactionHistory";
            this.ButtonTransactionHistory.Size = new System.Drawing.Size(112, 23);
            this.ButtonTransactionHistory.TabIndex = 6;
            this.ButtonTransactionHistory.Text = "Історія транзакцій";
            this.ButtonTransactionHistory.UseVisualStyleBackColor = true;
            this.ButtonTransactionHistory.Click += new System.EventHandler(this.ButtonTransactionHistory_Click);
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Location = new System.Drawing.Point(16, 83);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(28, 13);
            this.LabelFullName.TabIndex = 7;
            this.LabelFullName.Text = "ПІБ:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelFullName);
            this.Controls.Add(this.ButtonTransactionHistory);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.ButtonFindClient);
            this.Controls.Add(this.TextBoxClientData);
            this.Controls.Add(this.LabelWorkerName);
            this.Controls.Add(this.LabelClientMainData);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Центр обіну валюти";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelClientMainData;
        private System.Windows.Forms.Label LabelWorkerName;
        private System.Windows.Forms.TextBox TextBoxClientData;
        private System.Windows.Forms.Button ButtonFindClient;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Button ButtonTransactionHistory;
        private System.Windows.Forms.Label LabelFullName;
    }
}