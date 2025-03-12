using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers= { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers("Numbers",numbers);
            PrintNumbers("Numbers",numbers.Where(x=>IsEven(x)));
             PrintNumbers("Numbers",numbers.Where(x=>IsOdd(x)));

        }
        static void PrintNumbers(string title , IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.WriteLine($"{title}: [");
            foreach (int number in numbers)
            {
                Console.Write($" {number}");
            }
            Console.WriteLine($" ]");
            Console.WriteLine();
        }
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        static bool IsOdd(int number)
        {

            if (number % 2 != 0)
            {
                return true;
            }
            else return false;
        }
    }
}
