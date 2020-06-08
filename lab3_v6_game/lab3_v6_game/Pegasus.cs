using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class Pegasus : Character
    {
        public Pegasus()
        {
            name = "pegasus";
            movable = new FlyAndGoMove();
            Console.WriteLine("Створено пегаса.");
        }
        public override void Change()
        {
            Console.WriteLine("Виберiть, що має робити персонаж: 1-ходити, 2 - лiтати");
            string move = Console.ReadLine();
            if (move == "1")
                movable = new GoMove();
            if (move == "2")
                movable = new FlyMove();
        }
    }
}
