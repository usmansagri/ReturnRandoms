using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnRandoms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] vs = getRandoms().ToArray(); // Get the list from getRandoms function and convert to array using ToArray
            Console.WriteLine();
            Console.WriteLine("No of elements returned: "+vs.Length);
            Console.WriteLine("Returned elements: ");

            // Iterate and print elements of array
            // This program should work wile returning n number of values :)
            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        private static List<int> getRandoms()
        {
            List<int> list = new List<int>();
            Random random = new Random();
            int r1 = random.Next(1, 29);
            Console.WriteLine("Number generated for r1: " + r1);
            list.Add(r1);
            int r2 = random.Next(1, 29);
            Console.WriteLine("Number generated for r2: " + r2);
            list.Add(r2);
            Console.WriteLine("Numbers added successfully to the list.");
            return list;
        }

    }
}
