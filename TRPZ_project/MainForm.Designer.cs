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
            this.LabelClientFullName = new System.Windows.Forms.Label();
            this.LabelClientDataBirth = new System.Windows.Forms.Label();
            this.ComboBoxCurrencyFrom = new System.Windows.Forms.ComboBox();
            this.ComboBoxCurrencyTo = new System.Windows.Forms.ComboBox();
            this.TextBoxSuma = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LabelСurrencyFrom = new System.Windows.Forms.Label();
            this.LabelСurrencyTo = new System.Windows.Forms.Label();
            this.LabelSuma = new System.Windows.Forms.Label();
            this.LabelAmountForIssue = new System.Windows.Forms.Label();
            this.TextBoxAmountForIssue = new System.Windows.Forms.TextBox();
            this.BtnCreateReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelClientMainData
            // 
            this.LabelClientMainData.AutoSize = true;
            this.LabelClientMainData.Location = new System.Drawing.Point(9, 73);
            this.LabelClientMainData.Name = "LabelClientMainData";
            this.LabelClientMainData.Size = new System.Drawing.Size(135, 13);
            this.LabelClientMainData.TabIndex = 1;
            this.LabelClientMainData.Text = "Серія та номер паспорту:";
            // 
            // LabelWorkerName
            // 
            this.LabelWorkerName.AutoSize = true;
            this.LabelWorkerName.Location = new System.Drawing.Point(12, 9);
            this.LabelWorkerName.Name = "LabelWorkerName";
            this.LabelWorkerName.Size = new System.Drawing.Size(70, 13);
            this.LabelWorkerName.TabIndex = 2;
            this.LabelWorkerName.Text = "WorkerName";
            this.LabelWorkerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxClientData
            // 
            this.TextBoxClientData.Location = new System.Drawing.Point(150, 70);
            this.TextBoxClientData.Name = "TextBoxClientData";
            this.TextBoxClientData.Size = new System.Drawing.Size(137, 20);
            this.TextBoxClientData.TabIndex = 3;
            this.TextBoxClientData.Text = "KA756783";
            // 
            // ButtonFindClient
            // 
            this.ButtonFindClient.Location = new System.Drawing.Point(12, 98);
            this.ButtonFindClient.Name = "ButtonFindClient";
            this.ButtonFindClient.Size = new System.Drawing.Size(275, 23);
            this.ButtonFindClient.TabIndex = 4;
            this.ButtonFindClient.Text = "Пошук";
            this.ButtonFindClient.UseVisualStyleBackColor = true;
            this.ButtonFindClient.Click += new System.EventHandler(this.ButtonFindClient_Click);
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Location = new System.Drawing.Point(12, 37);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(132, 23);
            this.ButtonAddClient.TabIndex = 5;
            this.ButtonAddClient.Text = "Додати клієнта";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // ButtonTransactionHistory
            // 
            this.ButtonTransactionHistory.Location = new System.Drawing.Point(150, 37);
            this.ButtonTransactionHistory.Name = "ButtonTransactionHistory";
            this.ButtonTransactionHistory.Size = new System.Drawing.Size(137, 23);
            this.ButtonTransactionHistory.TabIndex = 6;
            this.ButtonTransactionHistory.Text = "Історія транзакцій";
            this.ButtonTransactionHistory.UseVisualStyleBackColor = true;
            this.ButtonTransactionHistory.Click += new System.EventHandler(this.ButtonTransactionHistory_Click);
            // 
            // LabelClientFullName
            // 
            this.LabelClientFullName.AutoSize = true;
            this.LabelClientFullName.Location = new System.Drawing.Point(12, 133);
            this.LabelClientFullName.Name = "LabelClientFullName";
            this.LabelClientFullName.Size = new System.Drawing.Size(31, 13);
            this.LabelClientFullName.TabIndex = 7;
            this.LabelClientFullName.Text = "ПІБ: ";
            // 
            // LabelClientDataBirth
            // 
            this.LabelClientDataBirth.AutoSize = true;
            this.LabelClientDataBirth.Location = new System.Drawing.Point(11, 152);
            this.LabelClientDataBirth.Name = "LabelClientDataBirth";
            this.LabelClientDataBirth.Size = new System.Drawing.Size(104, 13);
            this.LabelClientDataBirth.TabIndex = 8;
            this.LabelClientDataBirth.Text = "Дата народження: ";
            // 
            // ComboBoxCurrencyFrom
            // 
            this.ComboBoxCurrencyFrom.FormattingEnabled = true;
            this.ComboBoxCurrencyFrom.Location = new System.Drawing.Point(26, 196);
            this.ComboBoxCurrencyFrom.Name = "ComboBoxCurrencyFrom";
            this.ComboBoxCurrencyFrom.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCurrencyFrom.TabIndex = 9;
            // 
            // ComboBoxCurrencyTo
            // 
            this.ComboBoxCurrencyTo.FormattingEnabled = true;
            this.ComboBoxCurrencyTo.Location = new System.Drawing.Point(154, 196);
            this.ComboBoxCurrencyTo.Name = "ComboBoxCurrencyTo";
            this.ComboBoxCurrencyTo.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCurrencyTo.TabIndex = 10;
            // 
            // TextBoxSuma
            // 
            this.TextBoxSuma.Location = new System.Drawing.Point(26, 241);
            this.TextBoxSuma.Name = "TextBoxSuma";
            this.TextBoxSuma.Size = new System.Drawing.Size(210, 20);
            this.TextBoxSuma.TabIndex = 11;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(243, 239);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(32, 23);
            this.BtnOK.TabIndex = 12;
            this.BtnOK.Text = "ОК";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LabelСurrencyFrom
            // 
            this.LabelСurrencyFrom.AutoSize = true;
            this.LabelСurrencyFrom.Location = new System.Drawing.Point(40, 177);
            this.LabelСurrencyFrom.Name = "LabelСurrencyFrom";
            this.LabelСurrencyFrom.Size = new System.Drawing.Size(94, 13);
            this.LabelСurrencyFrom.TabIndex = 13;
            this.LabelСurrencyFrom.Text = "Валюта продажу:";
            // 
            // LabelСurrencyTo
            // 
            this.LabelСurrencyTo.AutoSize = true;
            this.LabelСurrencyTo.Location = new System.Drawing.Point(174, 177);
            this.LabelСurrencyTo.Name = "LabelСurrencyTo";
            this.LabelСurrencyTo.Size = new System.Drawing.Size(84, 13);
            this.LabelСurrencyTo.TabIndex = 14;
            this.LabelСurrencyTo.Text = "Валюта купівлі:";
            // 
            // LabelSuma
            // 
            this.LabelSuma.AutoSize = true;
            this.LabelSuma.Location = new System.Drawing.Point(119, 225);
            this.LabelSuma.Name = "LabelSuma";
            this.LabelSuma.Size = new System.Drawing.Size(69, 13);
            this.LabelSuma.TabIndex = 15;
            this.LabelSuma.Text = "Сума обміну";
            // 
            // LabelAmountForIssue
            // 
            this.LabelAmountForIssue.AutoSize = true;
            this.LabelAmountForIssue.Location = new System.Drawing.Point(119, 269);
            this.LabelAmountForIssue.Name = "LabelAmountForIssue";
            this.LabelAmountForIssue.Size = new System.Drawing.Size(67, 13);
            this.LabelAmountForIssue.TabIndex = 16;
            this.LabelAmountForIssue.Text = "Сума видачі";
            // 
            // TextBoxAmountForIssue
            // 
            this.TextBoxAmountForIssue.Location = new System.Drawing.Point(26, 285);
            this.TextBoxAmountForIssue.Name = "TextBoxAmountForIssue";
            this.TextBoxAmountForIssue.Size = new System.Drawing.Size(249, 20);
            this.TextBoxAmountForIssue.TabIndex = 17;
            // 
            // BtnCreateReceipt
            // 
            this.BtnCreateReceipt.Location = new System.Drawing.Point(26, 315);
            this.BtnCreateReceipt.Name = "BtnCreateReceipt";
            this.BtnCreateReceipt.Size = new System.Drawing.Size(249, 23);
            this.BtnCreateReceipt.TabIndex = 18;
            this.BtnCreateReceipt.Text = "Створити транзакцію";
            this.BtnCreateReceipt.UseVisualStyleBackColor = true;
            this.BtnCreateReceipt.Click += new System.EventHandler(this.BtnCreateReceipt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 372);
            this.Controls.Add(this.BtnCreateReceipt);
            this.Controls.Add(this.TextBoxAmountForIssue);
            this.Controls.Add(this.LabelAmountForIssue);
            this.Controls.Add(this.LabelSuma);
            this.Controls.Add(this.LabelСurrencyTo);
            this.Controls.Add(this.LabelСurrencyFrom);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TextBoxSuma);
            this.Controls.Add(this.ComboBoxCurrencyTo);
            this.Controls.Add(this.ComboBoxCurrencyFrom);
            this.Controls.Add(this.LabelClientDataBirth);
            this.Controls.Add(this.LabelClientFullName);
            this.Controls.Add(this.ButtonTransactionHistory);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.ButtonFindClient);
            this.Controls.Add(this.TextBoxClientData);
            this.Controls.Add(this.LabelWorkerName);
            this.Controls.Add(this.LabelClientMainData);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label LabelClientFullName;
        private System.Windows.Forms.Label LabelClientDataBirth;
        private System.Windows.Forms.ComboBox ComboBoxCurrencyFrom;
        private System.Windows.Forms.ComboBox ComboBoxCurrencyTo;
        private System.Windows.Forms.TextBox TextBoxSuma;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LabelСurrencyFrom;
        private System.Windows.Forms.Label LabelСurrencyTo;
        private System.Windows.Forms.Label LabelSuma;
        private System.Windows.Forms.Label LabelAmountForIssue;
        private System.Windows.Forms.TextBox TextBoxAmountForIssue;
        private System.Windows.Forms.Button BtnCreateReceipt;
    }
}