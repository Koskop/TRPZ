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
    public partial class AddNewClientForm : Form
    {
        List<Client> clients = new List<Client>();
        public AddNewClientForm(List<Client> c)
        {
            InitializeComponent();
            clients = c;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Client newClient = new Client(clients.Count+1, TextBoxSeconName.Text  + " " + TextBoxFirstName.Text + " " + TextBoxFatherName.Text, TextBoxDataBirth.Text, TextBoxPassportSeries.Text, Convert.ToInt32(TextBoxPassportNumber.Text));
// зробити перевіку на те чи вже не існує такого клієнта
        }
        private void AddNewClientForm_Load(object sender, EventArgs e)
        {

        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
