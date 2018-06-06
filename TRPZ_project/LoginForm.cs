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
using System.IO;

namespace TRPZ_project
{
    public partial class LoginForm : Form
    {
        private bool AllOk = false;
        private string EnteredLogin = "", EnteredPassword = "", WorkerName = "";
        private int WorkerDepartmentId = 0, WorkerId = 0;
        List<Worker> workers = new List<Worker>();
        List<Department> departments = new List<Department>();


        public LoginForm(List<Worker> wor,List<Department> dep)
        {
            InitializeComponent();
            workers = wor;
            departments = dep;
            for (int i = 0; i < departments.Count; i++)
            {
                ComboBoxDepartments.Items.Add(departments.ElementAt(i).getId());
            }
            ComboBoxDepartments.Refresh();
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
            if (TextBoxLogin.Text == "" || TextBoxPassword.Text == "" || ComboBoxDepartments.SelectedIndex == -1)
            {
                MessageBox.Show("Перевірте введені данні на правильність. \nПоля не можуть бути пустими!","Помилка");
            }
            else
            {
                EnteredLogin = TextBoxLogin.Text.ToLower();
                EnteredPassword = TextBoxPassword.Text;

                //Crypto
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(EnteredPassword));
                EnteredPassword = BitConverter.ToString(checkSum).Replace("-", String.Empty);

                EnteredPassword = EnteredPassword.ToLower();

                if (Autentification(EnteredLogin, EnteredPassword))
                {
                    WorkerDepartmentId = ComboBoxDepartments.SelectedIndex + 1;
                    AllOk = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Перевірте введені данні на правильність. \nне знайдено пари логін/пароль", "Помилка");
                }
            }
        }

        private bool Autentification(string l, string p)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers.ElementAt(i).getLogin() == EnteredLogin && workers.ElementAt(i).getPassword() == EnteredPassword) {
                    WorkerName = workers.ElementAt(i).getFullName();
                    WorkerId = workers.ElementAt(i).getWorkerID();
                    return true;
                }
            }
            return false;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!AllOk)
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TextBoxLogin.Text = "admin";
            TextBoxPassword.Text = "1";
            ComboBoxDepartments.SelectedIndex = 1;            
        }

        public string getWorkerName()
        {
            return WorkerName;
        }
        public int getWorkerDepartmentId()
        {
            return WorkerDepartmentId;
        }
        public int getWorkerId()
        {
            return WorkerId;
        }
    }
}
