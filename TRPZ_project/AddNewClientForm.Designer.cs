namespace TRPZ_project
{
    partial class AddNewClientForm
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelSeconName = new System.Windows.Forms.Label();
            this.LabelFatherName = new System.Windows.Forms.Label();
            this.LabelPassport = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxSeconName = new System.Windows.Forms.TextBox();
            this.TextBoxFatherName = new System.Windows.Forms.TextBox();
            this.TextBoxPassport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(154, 126);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Відміна";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(278, 126);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Зберегти";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(13, 24);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(29, 13);
            this.LabelFirstName.TabIndex = 2;
            this.LabelFirstName.Text = "Ім\'я:";
            // 
            // LabelSeconName
            // 
            this.LabelSeconName.AutoSize = true;
            this.LabelSeconName.Location = new System.Drawing.Point(13, 47);
            this.LabelSeconName.Name = "LabelSeconName";
            this.LabelSeconName.Size = new System.Drawing.Size(59, 13);
            this.LabelSeconName.TabIndex = 3;
            this.LabelSeconName.Text = "Прізвище:";
            // 
            // LabelFatherName
            // 
            this.LabelFatherName.AutoSize = true;
            this.LabelFatherName.Location = new System.Drawing.Point(13, 70);
            this.LabelFatherName.Name = "LabelFatherName";
            this.LabelFatherName.Size = new System.Drawing.Size(67, 13);
            this.LabelFatherName.TabIndex = 4;
            this.LabelFatherName.Text = "Побатькові:";
            // 
            // LabelPassport
            // 
            this.LabelPassport.AutoSize = true;
            this.LabelPassport.Location = new System.Drawing.Point(13, 93);
            this.LabelPassport.Name = "LabelPassport";
            this.LabelPassport.Size = new System.Drawing.Size(53, 13);
            this.LabelPassport.TabIndex = 5;
            this.LabelPassport.Text = "Паспорт:";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(88, 21);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(265, 20);
            this.TextBoxFirstName.TabIndex = 6;
            // 
            // TextBoxSeconName
            // 
            this.TextBoxSeconName.Location = new System.Drawing.Point(88, 44);
            this.TextBoxSeconName.Name = "TextBoxSeconName";
            this.TextBoxSeconName.Size = new System.Drawing.Size(265, 20);
            this.TextBoxSeconName.TabIndex = 7;
            // 
            // TextBoxFatherName
            // 
            this.TextBoxFatherName.Location = new System.Drawing.Point(88, 67);
            this.TextBoxFatherName.Name = "TextBoxFatherName";
            this.TextBoxFatherName.Size = new System.Drawing.Size(265, 20);
            this.TextBoxFatherName.TabIndex = 8;
            // 
            // TextBoxPassport
            // 
            this.TextBoxPassport.Location = new System.Drawing.Point(88, 90);
            this.TextBoxPassport.Name = "TextBoxPassport";
            this.TextBoxPassport.Size = new System.Drawing.Size(265, 20);
            this.TextBoxPassport.TabIndex = 9;
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 159);
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxPassport);
            this.Controls.Add(this.TextBoxFatherName);
            this.Controls.Add(this.TextBoxSeconName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LabelPassport);
            this.Controls.Add(this.LabelFatherName);
            this.Controls.Add(this.LabelSeconName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Додати клієнта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelSeconName;
        private System.Windows.Forms.Label LabelFatherName;
        private System.Windows.Forms.Label LabelPassport;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxSeconName;
        private System.Windows.Forms.TextBox TextBoxFatherName;
        private System.Windows.Forms.TextBox TextBoxPassport;
    }
}