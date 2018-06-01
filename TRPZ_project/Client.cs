using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_project
{
    class Client
    {
        int clientID = 0;
        string fullName = "";
        string dateBirth = "";
        string passportSeries = "";
        int passportNumer = 0;
        public Client(int ID,  string fN, string dB, string pS, int pN)
        {
            setClientID(ID);
            setFullName(fN);
            setDateBirth(dB);
            setPassportSeries(pS);
            setPassportNumer(pN);
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
        public void setPassportNumer(int pn)
        {
            passportNumer = pn;
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
        public int getPassportNumer()
        {
            return passportNumer;
        }
    }
}
