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
        int workerID = 0;
        int departmentID = 0;
        string data = "";
        string time = "";
        string from = "";
        string to = "";
        double suma = 0;
        public Receipt(int rID, int cID, int wID, int dID, string d, string t, string f, string to, double s)
        {
            setReceiptID(rID);
            setClientID(cID);
            setWorkerID(wID);
            setDepartmentID(dID);
            setData(d);
            setTime(t);
            setFrom(f);
            setTo(to);
            setSuma(s);
        }
        private void setReceiptID(int s)
        {
            receiptID = s;
        }
        private void setClientID(int s)
        {
            clientID = s;
        }
        private void setWorkerID(int s)
        {
            workerID = s;
        }
        private void setDepartmentID(int s)
        {
            departmentID = s;
        }
        private void setData(string s)
        {
            data = s;
        }
        private void setTime(string s)
        {
            time = s;
        }
        private void setFrom(string s)
        {
            from = s;
        }
        private void setTo(string s)
        {
            to = s;
        }
        private void setSuma(double s)
        {
            suma = s;
        }
        private int getReceiptID()
        {
            return receiptID;
        }
        private int getClientID()
        {
            return clientID;
        }
        private int getWorkerID()
        {
            return workerID;
        }
        private int getDepartmentID()
        {
            return departmentID;
        }
        private string getData()
        {
            return data;
        }
        private string getTime()
        {
            return time;
        }
        private string getFrom()
        {
            return from;
        }
        private string getTo()
        {
            return to;
        }
        private double getSuma()
        {
            return suma;
        }
    }
}
