using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class Harpy : Character
    {
        public Harpy()
        {
            name = "harpy";
            movable = new FlyMove();
            Console.WriteLine("Створено гарпiю.");
        }
        public override void Change()
        {
            Console.WriteLine("Тип руху персонажа змiнити неможливо.");
        }
    }
}
