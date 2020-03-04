using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this randomizer app!\n");

            int qtyPeople = Logic.EnterQtyElements();

            List<string> names = Logic.EnterNames(qtyPeople);

            int amountPeople = names.Count;
            int minRnd = 1;

            int result;

            Console.WriteLine("Blåa gruppen:\n");

            bool thereAreElements = names.Any();

            while (thereAreElements)
            {
                int maxRnd = names.Count + 1;
                result = rng.Next(minRnd, maxRnd) - 1;

                Console.WriteLine(names[result]);
                names.Remove(names[result]);

                thereAreElements = names.Any();

                System.Threading.Thread.Sleep(1500);

                if (thereAreElements)
                {
                    Shuffle(names);
                }
                if (names.Count == amountPeople / 2)
                {
                    Console.WriteLine("------------");
                    Console.WriteLine("Vita gruppen:\n");
                }
            }

            Console.ReadKey();
        }

        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
