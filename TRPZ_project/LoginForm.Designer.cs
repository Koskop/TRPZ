namespace TRPZ_project
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelTitleNameApp = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonShowPassword = new System.Windows.Forms.Button();
            this.ButtonEnterToSystem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelDepartmentNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitleNameApp
            // 
            this.LabelTitleNameApp.AutoSize = true;
            this.LabelTitleNameApp.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitleNameApp.Location = new System.Drawing.Point(82, 9);
            this.LabelTitleNameApp.Name = "LabelTitleNameApp";
            this.LabelTitleNameApp.Size = new System.Drawing.Size(207, 26);
            this.LabelTitleNameApp.TabIndex = 0;
            this.LabelTitleNameApp.Text = "Центр обіну валюти";
            this.LabelTitleNameApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(13, 66);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(37, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Логін:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(13, 89);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(48, 13);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Пароль:";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(87, 59);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(216, 20);
            this.TextBoxLogin.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(87, 81);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(189, 20);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // ButtonShowPassword
            // 
            this.ButtonShowPassword.Location = new System.Drawing.Point(282, 81);
            this.ButtonShowPassword.Name = "ButtonShowPassword";
            this.ButtonShowPassword.Size = new System.Drawing.Size(21, 23);
            this.ButtonShowPassword.TabIndex = 5;
            this.ButtonShowPassword.UseVisualStyleBackColor = true;
            this.ButtonShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonShowPassword_MouseDown);
            this.ButtonShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonShowPassword_MouseUp);
            // 
            // ButtonEnterToSystem
            // 
            this.ButtonEnterToSystem.Location = new System.Drawing.Point(258, 126);
            this.ButtonEnterToSystem.Name = "ButtonEnterToSystem";
            this.ButtonEnterToSystem.Size = new System.Drawing.Size(114, 23);
            this.ButtonEnterToSystem.TabIndex = 6;
            this.ButtonEnterToSystem.Text = "Вхід в систему";
            this.ButtonEnterToSystem.UseVisualStyleBackColor = true;
            this.ButtonEnterToSystem.Click += new System.EventHandler(this.ButtonEnterToSystem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // LabelDepartmentNumber
            // 
            this.LabelDepartmentNumber.AutoSize = true;
            this.LabelDepartmentNumber.Location = new System.Drawing.Point(13, 131);
            this.LabelDepartmentNumber.Name = "LabelDepartmentNumber";
            this.LabelDepartmentNumber.Size = new System.Drawing.Size(74, 13);
            this.LabelDepartmentNumber.TabIndex = 8;
            this.LabelDepartmentNumber.Text = "Відділення №";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.LabelDepartmentNumber);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ButtonEnterToSystem);
            this.Controls.Add(this.ButtonShowPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelTitleNameApp);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід - Центр обіну валюти";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitleNameApp;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonShowPassword;
        private System.Windows.Forms.Button ButtonEnterToSystem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelDepartmentNumber;
    }
}

