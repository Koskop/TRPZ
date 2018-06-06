using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_project
{
    public class Client
    {
        int clientID = 0;
        string fullName = "";
        string dateBirth = "";
        string passportSeries = "";
        int passportNumber = 0;
        public Client(int ID, string fN, string dB, string pS, int pN)
        {
            setClientID(ID);
            setFullName(fN);
            setDateBirth(dB);
            setPassportSeries(pS);
            setPassportNumber(pN);
        }
        public string DataForWrite()
        {
            string tmp = Convert.ToString(clientID) + '\n' + fullName + '\n' + dateBirth + '\n' + passportSeries + '\n' + Convert.ToString(passportNumber) + '\n';
            return tmp;
        }
        public void setClientID(int i)
        {
            clientID = i;
        }
        public void setFullName(string fn)
        {
            fullName = fn;
        }
        public void setDateBirth(string db)
        {
            dateBirth = db;
        }
        public void setPassportSeries(string ps)
        {
            passportSeries = ps;
        }
        public void setPassportNumber(int pn)
        {
            passportNumber = pn;
        }
        public int getClientID()
        {
            return clientID;
        }
        public string getFullName()
        {
            return fullName;
        }
        public string getDateBirth()
        {
            return dateBirth;
        }
        public string getPassportSeries()
        {
            return passportSeries;
        }
        public int getPassportNumber()
        {
            return passportNumber;
        }
    }
}
