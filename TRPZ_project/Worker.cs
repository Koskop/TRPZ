using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_project
{
    class Worker
    {
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

        public Worker(int ID, string l, string p, string fN, string dB, string pS, int pN, string wS, int wN, string dSW, string dEW)
        {
            setWorkerID(ID);
            setLogin(l);
            setPassword(p);
            setFullName(fN);
            setDateBirth(dB);
            setPassportSeries(pS);
            setPassportNumer(pN);
            setWorkbookSeries(wS);
            setWorkbookNumber(wN);
            setDateStartWork(dSW);
            setDateEndWork(dEW);

        }
        public void setWorkerID(int i)
        {
            workerID = i;
        }
        public void setLogin(string l)
        {
            login = l;
        }
        public void setPassword(string p)
        {
            password = p;
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
        public void setWorkbookSeries(string ws)
        {
            workbookSeries = ws;
        }
        public void setWorkbookNumber(int wn)
        {
            workbookNumber = wn;
        }
        public void setDateStartWork(string dsw)
        {
            dateStartWork = dsw;
        }
        public void setDateEndWork(string dew)
        {
            dateEndWork = dew;
        }
        public int getWorkerID()
        {
            return workerID;
        }
        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
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
        public string getWorkbookSeries()
        {
            return workbookSeries;
        }
        public int getWorkbookNumber()
        {
            return workbookNumber;
        }
        public string getDateStartWork()
        {
            return dateStartWork;
        }
        public string getDateEndWork()
        {
            return dateEndWork;
        }
    }
}
