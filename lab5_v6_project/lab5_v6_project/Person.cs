using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_v6_project
{
    class Person
    {
        private string name;
        private string position;

        public Person(/*int num,*/string n, string p)
        {
            //id = num;
            name = n;
            position = p;
        }
        public override string ToString()
        {
            return "Name  - " + this.Name + ". Position - " + this.Position;
        }
        //public int Id
        //{
        //    get 
        //    { 
        //        return id;
        //    }
        //    set 
        //    { 
        //        id = value; 
        //    }
        //}
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
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
    }
}
