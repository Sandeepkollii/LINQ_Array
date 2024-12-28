using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> strings = new List<string>();

            Console.WriteLine("Enter the strings one by one. Type 'done' when finished:");

           
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;

                strings.Add(input);
            }

         
            if (strings.Count == 0)
            {
                Console.WriteLine("No strings were entered.");
            }
            else
            {
                List<string> sortedStrings = strings.OrderBy(s => s).ToList();

                
                Console.WriteLine("Sorted Strings are:");
                foreach (var str in sortedStrings)
                {
                    Console.WriteLine(str);
                }
            }

            Console.ReadLine();
        }
    }
}
