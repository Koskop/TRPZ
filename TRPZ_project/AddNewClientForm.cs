using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TRPZ_project
{
    public partial class AddNewClientForm : Form
    {
        List<Client> clients = new List<Client>();
        Client newClient;
        public AddNewClientForm(List<Client> c)
        {
            InitializeComponent();
            clients = c;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxSeconName.Text == "" || TextBoxFirstName.Text == "" || TextBoxFatherName.Text == "" || TextBoxDataBirth.Text == "" || TextBoxPassportSeries.Text == "" || TextBoxPassportNumber.Text == "")
            {
                MessageBox.Show("Всі поля обов'язкові для вводу!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(TextBoxPassportNumber.Text.Length != 6 || TextBoxPassportSeries.Text.Length != 2)
                {
                    MessageBox.Show("Перевірте правильність введення паспортних даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    newClient = new Client(clients.Count + 1, TextBoxSeconName.Text + " " + TextBoxFirstName.Text + " " + TextBoxFatherName.Text, TextBoxDataBirth.Text, TextBoxPassportSeries.Text, Convert.ToInt32(TextBoxPassportNumber.Text));
                }
            }
            if (!FindClient())
            {
                clients.Add(newClient);
                RewriteClientDB();
                MessageBox.Show("Новго клієнта успішно додано!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        private void AddNewClientForm_Load(object sender, EventArgs e)
        {

        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дійсно відмінити додавання нового користувача?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool FindClient()
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if(clients.ElementAt(i).getPassportSeries() == TextBoxPassportSeries.Text && clients.ElementAt(i).getPassportNumber() == Convert.ToInt32(TextBoxPassportNumber.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void RewriteClientDB()
        {
            string tmp = Convert.ToString(clients.Count + "\n");
            for (int i = 0; i < clients.Count; i++)
                tmp += clients.ElementAt(i).DataForWrite();
            File.WriteAllText("Client.db", tmp);
        }

        public List<Client> getNewClientsDB()
        {
            return clients;
        }
    }
}
