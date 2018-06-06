using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_project
{
    public class Receipt
    {
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

        public Receipt(int rID, int cID, string cN, int wID, string wN, int dID, string dT, string f, double sF, string to, double sT)
        {
            setReceiptID(rID);
            setClientID(cID);
            setClientName(cN);
            setWorkerID(wID);
            setWorkerName(wN);
            setDepartmentID(dID);
            setDataTime(dT);
            setFrom(f);
            setTo(to);
            setSumaFrom(sF);
            setSumaTo(sT);
        }
        public string DataForList()
        {
            string tmp = Convert.ToString(receiptID) + ' ' + clientName + ' ' + dataTime;
            return tmp;
        }
        public string DataForWrite()
        {
            string tmp = Convert.ToString(receiptID) + '\n' + Convert.ToString(clientID) + '\n'+ clientName + '\n' + Convert.ToString(workerID) + '\n' + workerName + '\n' + Convert.ToString(departmentID) + '\n' + dataTime + '\n' + from + '\n' + Convert.ToString(sumaFrom) + '\n' + to + '\n' + Convert.ToString(sumaTo) + '\n';
            return tmp;
        }
        private void setReceiptID(int s)
        {
            receiptID = s;
        }
        private void setClientID(int s)
        {
            clientID = s;
        }
        private void setClientName(string s)
        {
            clientName = s;
        }
        private void setWorkerID(int s)
        {
            workerID = s;
        }
        private void setWorkerName(string s)
        {
            workerName = s;
        }
        private void setDepartmentID(int s)
        {
            departmentID = s;
        }
        private void setDataTime(string s)
        {
            dataTime = s;
        }
        private void setFrom(string s)
        {
            from = s;
        }
        private void setTo(string s)
        {
            to = s;
        }
        private void setSumaFrom(double s)
        {
            sumaFrom = s;
        }
        private void setSumaTo(double s)
        {
            sumaTo = s;
        }
        public int getReceiptID()
        {
            return receiptID;
        }
        public int getClientID()
        {
            return clientID;
        }
        public string getClientName()
        {
            return clientName;
        }
        public int getWorkerID()
        {
            return workerID;
        }
        public string getWorkerName()
        {
            return workerName;
        }
        public int getDepartmentID()
        {
            return departmentID;
        }
        public string getDataTime()
        {
            return dataTime;
        }
        public string getFrom()
        {
            return from;
        }
        public string getTo()
        {
            return to;
        }
        public double getSumaFrom()
        {
            return sumaFrom;
        }
        public double getSumaTo()
        {
            return sumaTo;
        }
    }
}
