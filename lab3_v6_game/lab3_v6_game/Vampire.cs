using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class Vampire : Character
    {
        public Vampire()
        {
            name = "vampire";
            movable =new FlyAndGoMove();
            Console.WriteLine("Створено вампiра.");
        }
        public override void Change()
        {
            Console.WriteLine("Виберiть, що має робити персонаж: 1-ходити, 2 - перетворитися на летючу мишу i лiтати");
            string move = Console.ReadLine();
            if (move == "1")
                movable = new GoMove();
            if (move == "2")
                movable = new FlyMove();
        }
    }
}
