using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenerationOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> numbers1 = Enumerable.Empty<string>();
            Console.WriteLine($"{numbers1.Count()}");//// 0

            IEnumerable<int> numbers2 = Enumerable.DefaultIfEmpty<int>(numbers1);
            Console.WriteLine($"{numbers2.Count()} :{numbers2.ElementAt(0)}");


           IEnumerable<int> numbers3=IEnumerable.Repeat(5, 10);
            foreach(var item in numbers3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            
            Console.ReadLine();


        }
    }
}
