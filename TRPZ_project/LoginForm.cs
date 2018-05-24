using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TRPZ_project
{
    public partial class LoginForm : Form
    {
        private bool AllOk = false;
        private string EnteredLogin = "", EnteredPassword = "";


        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = false;
        }

        private void ButtonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = true;
        }

        private void ButtonEnterToSystem_Click(object sender, EventArgs e)
        {

            if (TextBoxLogin.Text == "" || TextBoxPassword.Text == "")
            {
                MessageBox.Show("Перевірте введені данні на правильність. \nПоля не можуть бути пустими!","Помилка");
            }
            else
            {
                EnteredLogin = TextBoxLogin.Text;
                EnteredLogin = EnteredLogin.ToLower();
                EnteredPassword = TextBoxPassword.Text;

                //Crypto
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(EnteredPassword));
                EnteredPassword = BitConverter.ToString(checkSum).Replace("-", String.Empty);

                if (true) // база дала добро
                {
                    AllOk = true;
                    this.Close();
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!AllOk)
            Application.Exit();
        }

        public string getEnteredLogin()
        {
            return EnteredLogin;
        }
    }
}
