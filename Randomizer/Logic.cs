using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Logic
    {
        internal static int EnterQtyElements()
        {
            bool entryValid;
            int qtyPeople = 0;
            do
            {
                entryValid = true;
                Console.Write("Enter how any people you want to randomize: ");
                try
                {
                    qtyPeople = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Something went wrong, try again!");
                    entryValid = false;
                }

            } while (!entryValid);

            return qtyPeople;
        }

        internal static List<string> EnterNames(int qtyPeople)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < qtyPeople; i++)
            {
                Console.Write($"Enter name of element {i + 1}: ");
                string name = Console.ReadLine();
                names.Add(name);
            }

            return names;
        }
    }
}
