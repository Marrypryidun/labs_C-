using System;

namespace lab2_v6_country
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool f = false;
             Component Contry = new Region("Україна");
             Component Region = new Region("Тернопiльська");
             Component City = new Settlement("Тернопiль");
             Component Town = new Settlement("Бережани");
             Region.Add(City);
             Region.Add(Town);
             Contry.Add(Region);
             Contry.Display();
             f=Contry.Search("Україна ");
             if (f == false)
                 Console.WriteLine("За запитом нічого не знайдено.");
         */
            string ContryName, RegionName, CityName, search;
            Component Contry;
            Console.WriteLine("Введiть iм'я країни:");
            ContryName = Console.ReadLine();
            Contry = new Region(ContryName);
            do
            {
                Console.Clear();
                Console.WriteLine("Країна: " + ContryName);
                Console.WriteLine("         Меню");
                Console.WriteLine("1. Створити область/штат.");
                Console.WriteLine("2. Вивести iнформацiю про країну.");
                Console.WriteLine("3. Пошук.");
                Console.WriteLine("3. Вихiд.");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Введiть iм'я областi/штату:");
                        RegionName = Console.ReadLine();
                        Component Region = new Region(RegionName);

                        Console.WriteLine("Хочете створити населенi пункти в областi?(Введiть так або нi)");
                        string ch= Console.ReadLine();
                        while(ch=="так")
                        {
                            Console.WriteLine("Введiть iм'я населеного пункту:");
                            CityName = Console.ReadLine();
                            Component City = new Settlement(CityName);
                            Region.Add(City);
                            Console.WriteLine("Хочете додати ще один населений пункт?(Введiть так або нi)");
                            ch = Console.ReadLine();
                        }
                        Contry.Add(Region);
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Contry.Display();
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Введiть запит для пошуку:");
                        search= Console.ReadLine();
                        bool f = Contry.Search(search);
                        if (f == false)
                            Console.WriteLine("За запитом нiчого не знайдено.");
                        Console.WriteLine("Натиснiть Enter, щоб продовжити...");
                        Console.ReadLine();
                        break;
                    case "4":
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
