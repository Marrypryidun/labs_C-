using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_v6_game
{
    class Elf : Character
    {
        public Elf()
        {
            name = "elf";
            movable = new FlyAndGoMove();
            Console.WriteLine("Створено ельфа.");
        }

        public override void Change()
        {
            Console.WriteLine("Виберiть, що має робити персонаж: 1-ходити, 2 - лiтати за допомогою магiї");
            string move= Console.ReadLine();
            if (move == "1")
                movable = new GoMove();
            if (move == "2")
                movable = new FlyMove();
        }




    }
}
