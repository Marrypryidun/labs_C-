using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class Orc : Character
    {
        public Orc()
        {
            name="orc";
            movable = new GoMove();
            Console.WriteLine("Створено орка.");
        }
        public override void Change()
        {
            Console.WriteLine("Тип руху персонажа змiнити неможливо.");
        }
    }
}
