using System;
using System.Collections.Generic;
using System.Text;


namespace lab1_v6_civilization
{

    class Civilization
    {
        //List<citizen> citizens = new List<citizen>();
        private string name;
        private float territories;
        private int population;

        public Civilization()
        {
            name = "";
            territories = 0;
            population = 0;
     
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Territories
        {
            get { return territories; }
            set { territories = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public citizen AddCitizen(string type)
        {
            citizen person = CreateCitizen(type);
            population++;
            territories += person.Territories;
            person.informationCitizen();
            return person;
        }
        public citizen CreateCitizen(string type)
        {
            if (type == "aristocrat")
                return new aristocrat();
            else if (type == "warrior")
                return new warrior();
            else if (type == "worker")
                return new worker();
            return null;
        }
        public void informationCivilization()
        {
            Console.WriteLine("The name of civilization:  {0}", name);
            Console.WriteLine("Territories: {0}", territories);
            Console.WriteLine("Population: {0}", population);
        }
    }
}
