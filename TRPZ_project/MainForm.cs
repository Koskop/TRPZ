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
    public partial class MainForm : Form
    {
        bool btnOkIsPressed = false;
        bool clientIsFind = false;

        List<Worker> workers = new List<Worker>();
        List<Department> departments = new List<Department>();
        List<Client> clients = new List<Client>();
        List<Receipt> receipts = new List<Receipt>();
        List<Currency> currencys = new List<Currency>();

        public string st = "";
        private int WorkerId = 0 , WorkerDepartmentId = 0;
        private string WorkerName = "";
        private string ClientName = "", ClientDataBirth = "";
        private int ClientId = 0;

        public MainForm()
        {
            InitializeComponent();
            loadDB();
            for (int i = 0; i < currencys.Count; i++)
            {
                ComboBoxCurrencyFrom.Items.Add(currencys.ElementAt(i).getName());
                ComboBoxCurrencyTo.Items.Add(currencys.ElementAt(i).getName());
            }
        }
        private void loadDB()
        {
            loadWorkerDB();
            loadDepartmentdDB();
            loadClientDB();
            loadReceiptDB();
            loadCurrencytDB();
        }
        private void loadWorkerDB()
        {
            IEnumerable<String> userData = File.ReadLines("Worker.db");
            int workerID = 0;
            string login = "";
            string password = "";
            string fullName = "";
            string dateBirth = "";
            string passportSeries = "";
            int passportNumer = 0;
            string workbookSeries = "";
            int workbookNumber = 0;
            string dateStartWork = "";
            string dateEndWork = "";

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    workerID = Convert.ToInt32(userData.ElementAt(1 + 11 * i));
                    login = userData.ElementAt(2 + 11 * i);
                    password = userData.ElementAt(3 + 11 * i);
                    fullName = userData.ElementAt(4 + 11 * i);
                    dateBirth = userData.ElementAt(5 + 11 * i);
                    passportSeries = userData.ElementAt(6 + 11 * i);
                    passportNumer = Convert.ToInt32(userData.ElementAt(7 + 11 * i));
                    workbookSeries = userData.ElementAt(8 + 11 * i);
                    workbookNumber = Convert.ToInt32(userData.ElementAt(9 + 11 * i));
                    dateStartWork = userData.ElementAt(10 + 11 * i);
                    dateEndWork = userData.ElementAt(11 + 11 * i);

                    Worker worker = new Worker(workerID, login, password, fullName, dateBirth, passportSeries, passportNumer, workbookSeries, workbookNumber, dateStartWork, dateEndWork);
                    workers.Add(worker);
                }
        }
        private void loadDepartmentdDB()
        {
            IEnumerable<String> userData = File.ReadLines("Department.db");
            string id = "";
            string city = "";
            string street = "";
            string building = "";

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    id = userData.ElementAt(1 + 4 * i);
                    city = userData.ElementAt(2 + 4 * i);
                    street = userData.ElementAt(3 + 4 * i);
                    building = userData.ElementAt(4 + 4 * i);

                    Department department = new Department(id, city, street, building);
                    departments.Add(department);
                }
        }
        private void loadClientDB()
        {
            IEnumerable<String> userData = File.ReadLines("Client.db");
            int clientID = 0;
            string fullName = "";
            string dateBirth = "";
            string passportSeries = "";
            int passportNumber = 0;

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    clientID = Convert.ToInt32(userData.ElementAt(1 + 5 * i));
                    fullName = userData.ElementAt(2 + 5 * i);
                    dateBirth = userData.ElementAt(3 + 5 * i);
                    passportSeries = userData.ElementAt(4 + 5 * i);
                    passportNumber = Convert.ToInt32(userData.ElementAt(5 + 5 * i));

                    Client client = new Client(clientID, fullName, dateBirth, passportSeries, passportNumber);
                    clients.Add(client);
                }
        }
        private void loadReceiptDB()
        {
            IEnumerable<String> userData = File.ReadLines("Receipt.db");
            int receiptID = 0;
            int clientID = 0;
            string clientName = "";
            int workerID = 0;
            string workerName = "";
            int departmentID = 0;
            string dataTime = "";
            string from = "";
            double sumaFrom = 0;
            string to = "";
            double sumaTo = 0;

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    receiptID = Convert.ToInt32(userData.ElementAt(1 + 11 * i));
                    clientID = Convert.ToInt32(userData.ElementAt(2 + 11 * i));
                    clientName = userData.ElementAt(3 + 11 * i);
                    workerID = Convert.ToInt32(userData.ElementAt(4 + 11 * i));
                    workerName = userData.ElementAt(5 + 11 * i);
                    departmentID = Convert.ToInt32(userData.ElementAt(6 + 11 * i));
                    dataTime = userData.ElementAt(7 + 11 * i);
                    from = userData.ElementAt(8 + 11 * i);
                    sumaFrom = Convert.ToDouble(userData.ElementAt(9 + 11 * i));
                    to = userData.ElementAt(10 + 11 * i);
                    sumaTo = Convert.ToDouble(userData.ElementAt(11 + 11 * i));


                    Receipt receipt = new Receipt(receiptID, clientID, clientName, workerID, workerName, departmentID, dataTime, from, sumaFrom, to, sumaTo);
                    receipts.Add(receipt);
                }
        }
        private void loadCurrencytDB()
        {
            IEnumerable<String> userData = File.ReadLines("Currency.db");
            int id = 0;
            string name = "";
            double buy = 0, sell = 0;

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    id = Convert.ToInt32(userData.ElementAt(1 + 4 * i));
                    name = userData.ElementAt(2 + 4 * i);
                    buy = Convert.ToDouble(userData.ElementAt(3 + 4 * i));
                    sell = Convert.ToDouble(userData.ElementAt(4 + 4 * i));

                    Currency currency = new Currency(id, name, buy, sell);
                    currencys.Add(currency);
                }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(workers, departments);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            loginForm.Activate();
            setWorkerName(loginForm.getWorkerName());
            setWorkerDepartmentId(loginForm.getWorkerDepartmentId());
            setWorkerId(loginForm.getWorkerId());
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

            AddNewClientForm addNewClient = new AddNewClientForm(clients);
            addNewClient.StartPosition = FormStartPosition.CenterScreen;
            addNewClient.ShowDialog();
            addNewClient.Activate();

            clients = addNewClient.getNewClientsDB();
        }

        private void setWorkerName(string s)
        {
            WorkerName = s;
            LabelWorkerName.Text = WorkerName;
        }
        private void setWorkerDepartmentId(int s)
        {
            WorkerDepartmentId = s;
        }
        private void setWorkerId(int s)
        {
            WorkerId = s;
        }

        private void ButtonFindClient_Click(object sender, EventArgs e)
        {
            if (TextBoxClientData.Text.Length != 8)
            {
                MessageBox.Show("Помилкове введення!\nКількість символів у полі повинна рівнятись 8. \nВ полі повинно міститись 2 літрери та 6 цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string series = "", number = "";
                series += TextBoxClientData.Text[0];
                series += TextBoxClientData.Text[1];
                number += TextBoxClientData.Text[2];
                number += TextBoxClientData.Text[3];
                number += TextBoxClientData.Text[4];
                number += TextBoxClientData.Text[5];
                number += TextBoxClientData.Text[6];
                number += TextBoxClientData.Text[7];
                ClientId = FindClient(series, number);
                if (ClientId != 0)
                {
                    ClientName = clients.ElementAt(ClientId).getFullName();
                    ClientDataBirth = clients.ElementAt(ClientId).getDateBirth();
                    ClientId += 1;
                    LabelClientFullName.Text = "ПІБ: " + ClientName;
                    LabelClientDataBirth.Text = "Дата народження: " + ClientDataBirth;

                    clientIsFind = true;
                }
                else
                {
                    ClientName = "";
                    ClientDataBirth = "";
                    ClientId = 0;
                    LabelClientFullName.Text = "ПІБ: ";
                    LabelClientDataBirth.Text = "Дата народження: ";
                    MessageBox.Show("Клієнта не знайдено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!clientIsFind)
            {
                MessageBox.Show("Спочатку вкажіть клієнта!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ComboBoxCurrencyFrom.SelectedIndex == -1 || ComboBoxCurrencyTo.SelectedIndex == -1)
                {
                    MessageBox.Show("Оберіть валюти!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextBoxAmountForIssue.Text = "";
                }
                else
                {
                    if (TextBoxSuma.Text == "")
                    {
                        MessageBox.Show("Ви не ввели суму!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double cfrom = currencys.ElementAt(ComboBoxCurrencyFrom.SelectedIndex).getSell();
                        double cto = currencys.ElementAt(ComboBoxCurrencyTo.SelectedIndex).getBuy();
                        double sumBefor = Convert.ToDouble(TextBoxSuma.Text);
                        double sumAfter = Math.Round(sumBefor * ((1 / cto) * cfrom), 2);
                        TextBoxAmountForIssue.Text = Convert.ToString(sumAfter);
                        btnOkIsPressed = true;
                    }
                }
            }
        }

        private void BtnCreateReceipt_Click(object sender, EventArgs e)
        {
            if (!btnOkIsPressed)
            {
                MessageBox.Show("Спочатку обрахуйте суму!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string from = currencys.ElementAt(ComboBoxCurrencyFrom.SelectedIndex).getName();
                string to = currencys.ElementAt(ComboBoxCurrencyTo.SelectedIndex).getName();
                Receipt receipt = new Receipt(receipts.Count + 1, ClientId, ClientName, WorkerId, WorkerName, WorkerDepartmentId, DateTime.Now.ToString(), from, Convert.ToDouble(TextBoxSuma.Text), to, Convert.ToDouble(TextBoxAmountForIssue.Text));
                receipts.Add(receipt);
                string tmp = Convert.ToString(receipts.Count) + "\n";
                for (int i = 0; i < receipts.Count; i++)
                {
                    tmp += receipts.ElementAt(i).DataForWrite();
                }
                File.WriteAllText("Receipt.db", tmp);
                MessageBox.Show("Чек успішно додано в базу!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOkIsPressed = false;
            }
        }

        private void ButtonTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm(receipts);
            transactionHistoryForm.StartPosition = FormStartPosition.CenterScreen;
            transactionHistoryForm.ShowDialog();
            transactionHistoryForm.Activate();
        }

        private int FindClient(string series, string number)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients.ElementAt(i).getPassportSeries() == series && clients.ElementAt(i).getPassportNumber() == Convert.ToInt32(number))
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
