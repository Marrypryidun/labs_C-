using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class FactoryCharacter
    {
        public Character AddCharacter(string type)
        {
            Character person = CreateCharacter(type);
            //person.informationCitizen();
            person.Move();
            person.Change();
            person.Information();
            return person;
        }
        public Character CreateCharacter(string type)
        {
            if (type == "elf")
                return new Elf();
            else if (type == "ork")
                return new Orc();
            else if (type == "pegasus")
                return new Pegasus();
            else if (type == "troll")
                return new Troll();
            else if (type == "vampire")
                return new Vampire();
            else if (type == "harpy")
                return new Harpy();
            return null;
        }
        /*public void informationCivilization()
        {
            Console.WriteLine("The name of civilization:  {0}", name);
            Console.WriteLine("Territories: {0}", territories);
            Console.WriteLine("Population: {0}", population);
        }*/
    }
}
