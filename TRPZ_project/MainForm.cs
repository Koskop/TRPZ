using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPZ_project
{
    public partial class MainForm : Form
    {
        private string WorkerLogin = "", WorkerName = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            loginForm.Activate();
            this.setWorkerName(loginForm.getEnteredLogin());
        }

        public void setWorkerName(string s)
        {
            WorkerLogin = s;
            WorkerName = WorkerLogin; // пошук імені в базі по логіну з поверененням імені
            LabelWorkerName.Text = WorkerName;

        }
    }
}
