﻿using System;
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
    public partial class AddNewClientForm : Form
    {
        private string FirstName = "", SecondName = "", FatherName = "", Passport = "";

        public AddNewClientForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
