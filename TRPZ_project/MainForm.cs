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
        List<Worker> workers = new List<Worker>();
        List<Department> departments = new List<Department>();
        List<Client> clients = new List<Client>();
        List<Receipt> receipts = new List<Receipt>();

        public string st = "";
        int WorkerId = 0 , DepartmentId = 0;
        private string WorkerName = "";
        public MainForm()
        {
            InitializeComponent();
        }
        private void loadDB()
        {
            loadWorkerDB();
            loadDepartmentdDB();
            loadClientDB();
            loadReceiptDB();
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
            int passportNumer = 0;

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    clientID = Convert.ToInt32(userData.ElementAt(1 + 5 * i));
                    fullName = userData.ElementAt(2 + 5 * i);
                    dateBirth = userData.ElementAt(3 + 5 * i);
                    passportSeries = userData.ElementAt(4 + 5 * i);
                    passportNumer = Convert.ToInt32(userData.ElementAt(5 + 5 * i));

                    Client client = new Client(clientID, fullName, dateBirth, passportSeries, passportNumer);
                    clients.Add(client);
                }
        }
        private void loadReceiptDB()
        {
            IEnumerable<String> userData = File.ReadLines("Receipt.db");
            int receiptID = 0;
            int clientID = 0;
            int workerID = 0;
            int departmentID = 0;
            string data = "";
            string time = "";
            string from = "";
            string to = "";
            double suma = 0;

            if (Convert.ToInt32(userData.ElementAt(0)) != 0)
                for (int i = 0; i < Convert.ToInt32(userData.ElementAt(0)); i++)
                {
                    receiptID = Convert.ToInt32(userData.ElementAt(1 + 9 * i));
                    clientID = Convert.ToInt32(userData.ElementAt(2 + 9 * i));
                    workerID = Convert.ToInt32(userData.ElementAt(3 + 9 * i));
                    departmentID = Convert.ToInt32(userData.ElementAt(4 + 9 * i));
                    data = userData.ElementAt(5 + 9 * i);
                    time = userData.ElementAt(6 + 9 * i);
                    from = userData.ElementAt(7 + 9 * i);
                    to = userData.ElementAt(8 + 9 * i);
                    suma = Convert.ToDouble(userData.ElementAt(9 + 9 * i));

                    Receipt receipt = new Receipt(receiptID, clientID, workerID, departmentID, data, time, from, to, suma);
                    receipts.Add(receipt);
                }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadDB();
            LoginForm loginForm = new LoginForm(workers, departments);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            loginForm.Activate();
            setWorkerName(loginForm.getWorkerName());
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

            AddNewClientForm addNewClient = new AddNewClientForm(clients);
            addNewClient.StartPosition = FormStartPosition.CenterScreen;
            addNewClient.ShowDialog();
            addNewClient.Activate();
        }

        private void setWorkerName(string s)
        {
            WorkerName = s;
            LabelWorkerName.Text = WorkerName;

        }

        private void setDepartment(string s)
        {
            WorkerName = s;
            LabelWorkerName.Text = WorkerName;

        }

        private void ButtonTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryForm transactionHistoryForm = new TransactionHistoryForm();
            transactionHistoryForm.StartPosition = FormStartPosition.CenterScreen;
            transactionHistoryForm.ShowDialog();
            transactionHistoryForm.Activate();
        }
    }
}
