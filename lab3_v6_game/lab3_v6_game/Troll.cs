using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class Troll : Character
    {
        public Troll()
        {
            name = "troll";
            movable = new GoMove();
            Console.WriteLine("Створено троля.");
        }
        public override void Change()
        {
            Console.WriteLine("Тип руху персонажа змiнити неможливо.");
        }
    }
}
