using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prov2
{
    class Program
    {
        static Random gen; // deklareras här för användning i alla metoder
        static List<Car> cars; // same 

        static void Main(string[] args)
        {
            int index = 0;
            gen = new Random(); // ny generator för main
            cars = new List<Car>(); // deklarerar en lista att lägga car instanserna i

            SetUp(); // skapar bilar ifrån input

            while (true)
            {
                Console.WriteLine("Enter the index of the car you wish to search [1-{0}]", cars.Count);
                while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > cars.Count) // kör tills input är giltig
                {
                    Console.WriteLine("Enter the index (number) of the car you wish to search [1-{0}]", cars.Count);
                }

                if (!cars[index-1].alreadyChecked) // kollar om bilen är sökt sedan innan
                {
                    Console.WriteLine("Examining car {0}{1}", index, "...");
                    //Thread.Sleep(1000);

                    cars[index-1].alreadyChecked = true;
                    if (cars[index-1].Examine())
                    {
                        Console.WriteLine("Contraband detected ({0} stolen items)", cars[index-1].contrabandAmount); // contraband funnet
                    }
                    else Console.WriteLine("No contraband detected"); // bilen är ren eller inget contraband hittades
                }
                else Console.WriteLine("That car has already been checked!");

                Console.WriteLine("Press [Enter] to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void SetUp()
        {
            Console.WriteLine("How many cars should be examined?");
            int amount = 0;
            while (!int.TryParse(Console.ReadLine(), out amount) || amount <= 0) // kör så länge amount är 0 eller mindre
            {
                Console.WriteLine("Enter a number higher than 0");
            }
            for (int i = 0; i < amount; i++)
            {
                Thread.Sleep(37); // minskar risken att bilar blir samma

                if (gen.Next(0, 100) > 60) // 60 procent chans för ren bil
                {
                    Contraband car = new Contraband(); // ny contraband bil
                    cars.Add(car); // lägger bilen i listan
                }
                else
                {
                    Clean car = new Clean(); // ny ren bil
                    cars.Add(car); // lägger bilen i billistan
                }
            }
        }
    }
}
