using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_v6_civilization
{
    abstract class citizen
    {
        protected float money;
        protected string namerace;
        protected float territories;
        protected string objects = "forests,fields,dwelling, factories";
        public void informationCitizen()
        {
            Console.WriteLine("The name of the race:  {0}", namerace);
            Console.WriteLine("Financial stok: {0}", money);
            Console.WriteLine("Territories: {0}", territories);
            Console.WriteLine("Objects are lokated on the territory: {0}", objects);

        }
        public string Namerase
        {
            get { return namerace; }
            set { namerace = value; }
        }
        public float Money
        {
            get { return money; }
            set { money = value; }
        }
        public float Territories
        {
            get { return territories; }
            set { territories = value; }
        }
        public string Objects
        {
            get { return objects; }
            set { objects = value; }
        }
    }
}
