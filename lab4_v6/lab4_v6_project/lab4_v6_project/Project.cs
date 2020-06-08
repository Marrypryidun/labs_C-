using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace lab4_v6_project
{
    class Project
    {
        string code;
        string name;
        float price;
        DateTime date1 /*= new DateTime()*/;
        DateTime date2 /*= new DateTime()*/;
        public List<Person> Participants { get; set; }

        public Project(string c, string n, float p, DateTime d1,DateTime d2, List<Person> persons)
        {
            code = c;
            name = n;
            price = p;
            date1 = d1;
            date2 = d2;
            Participants = persons;
        }
        public override string ToString()
        {
            return "Code of the project " + this.Code + ". Name - " + this.Name + ". Price:" + this.Price.ToString() + Environment.NewLine+
                "Date of creation begining of project:" + this.Date1.ToShortDateString() + ". Date of creation finishing of project:" + this.Date2.ToShortDateString();
        }
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
            public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
            public DateTime Date1
           {
            get
            {
                return date1;
            }
            set
            {
                date1 = value;
            }
        }
        public DateTime Date2
        {
            get
            {
                return date2;
            }
            set
            {
                date2 = value;
            }
        }

    }

    
}
