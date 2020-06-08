using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    abstract class Character
    {
        public string name;
        public IMovable movable;
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
        abstract public void Change();
        
        public  void Move()
        {
            movable.Move();
        }
        public void Information()
        {
            Console.WriteLine("Тип персонажа: {0}", Name);
            Move();
        }
    }
}
