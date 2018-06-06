using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_project
{
    public class Currency
    {
        int id = 0;
        string name = "";
        double buy = 0, sell = 0;

        public Currency(int i, string n, double b, double s)
        {
            setId(i);
            setName(n);
            setBuy(b);
            setSell(s);
        }

        public void setId(int i)
        {
            id = i;
        }
        public void setName(string i)
        {
            name = i;
        }
        public void setBuy(double i)
        {
            buy = i;
        }
        public void setSell(double i)
        {
            sell = i;
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public double getBuy()
        {
            return buy;
        }
        public double getSell()
        {
            return sell;
        }
    }
}
