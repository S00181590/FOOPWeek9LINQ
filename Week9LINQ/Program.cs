using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            //The LINQ Query syntax
            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;

            foreach(int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());  
            }

            Console.ReadKey();

            //The LINQ Lambda syntax
            outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach(int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }

            Console.ReadKey();

        }
    }
}
