using System;

namespace lab3_v6_game
{
    class Program
    {
        static void Main()
        {
            FactoryCharacter My = new FactoryCharacter();
            Character character;
           // character= My.AddCharacter("elf");
            do
            {
                Console.Clear();
                Console.WriteLine("         MENU");
                Console.WriteLine("1. Створити ельфа.");
                Console.WriteLine("2. Створити гарпiю.");
                Console.WriteLine("3. Створити орка.");
                Console.WriteLine("4. Створити пегаса.");
                Console.WriteLine("5. Створити троля.");
                Console.WriteLine("6. Створити вампiра.");
                Console.WriteLine("7. Вихiд.");
                string option = Console.ReadLine();
                switch (option) 
                {
                    case "1":
                        character = My.AddCharacter("elf");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "2":
                        character = My.AddCharacter("harpy");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "3":
                        character = My.AddCharacter("ork");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "4":
                        character = My.AddCharacter("pegasus");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "5":
                        character = My.AddCharacter("troll");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "6":
                        character = My.AddCharacter("vampire");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("Помилка! Введiть iснуючий пункт меню.");
                            Console.ReadLine();
                            break;
                        }
                }
            } while (true);

        }
    }
}
