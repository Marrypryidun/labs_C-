using System;
using System.Collections.Generic;

namespace lab1_v6_civilization
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Civilization one=new Civilization();
            int number = 0,// номер цивілізації
                n = 1;//кількість цивілізацій
            List<Civilization> settlement = new List<Civilization>();
            Console.WriteLine("Enter name of civilization:");
            Name = Console.ReadLine();
            settlement.Add(one);
            settlement[number].Name = Name;


            do
            {
                Console.Clear();
                Console.WriteLine("Civilization: " + settlement[number].Name);
                Console.WriteLine("         MENU");
                Console.WriteLine("1. Create aristocrat.");
                Console.WriteLine("2. Create warrior.");
                Console.WriteLine("3. Create worker.");
                Console.WriteLine("4. Show information about civilization.");
                Console.WriteLine("5. Create new civilization.");
                Console.WriteLine("6. Change civilization.");
                Console.WriteLine("7. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        settlement[number].AddCitizen("aristocrat");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    case 2:
                        settlement[number].AddCitizen("warrior");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    case 3:
                        settlement[number].AddCitizen("worker");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    case 4:
                        settlement[number].informationCivilization();
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    case 5:
                        number++;
                        n++;
                        Console.WriteLine("Enter name of civilization:");
                        Name = Console.ReadLine();
                        Civilization created = new Civilization();
                        settlement.Add(created);
                        settlement[number].Name = Name;
                        break;
                    case 6:
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("=======Press {0} to select civilization===== ", i + 1);
                            settlement[i].informationCivilization();
                         }
                        int ch=  Convert.ToInt32(Console.ReadLine());
                        if (ch <= n)
                            number = ch-1;
                        else
                        { 
                            Console.WriteLine("Error! There is no civilization with that number ");
                        Console.ReadLine();
                            }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("Error! Enter an existing menu item.");
                            Console.ReadLine();
                            break;
                        }
                }
            } while (true);
            
        }
    }
}
