using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_project
{
    public class Department
    {
        string id = "";
        string city = "";
        string street = "";
        string building = "";
        public Department(string i, string c, string s, string b)
        {
            setId(i);
            setCity(c);
            setStreet(s);
            setBuilding(b);
        }
        public void setId(string i)
        {
            id = i;
        }
        public void setCity(string i)
        {
            city = i;
        }
        public void setStreet(string i)
        {
            street = i;
        }
        public void setBuilding(string i)
        {
            building = i;
        }
        public string getId()
        {
            return id;
        }
        public string getCity()
        {
            return city;
        }
        public string getStreet()
        {
            return street;
        }
        public string getBuilding()
        {
            return building;
        }
    }
}
