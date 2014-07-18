using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of numbers, add them together, and show the total
            var numberList = new List<int>() { 56, 65, 45, 3, 6, 40, 2, 9, 54, 60 };

            

            foreach (var item in numberList) { Console.WriteLine(item); }

            var numAdd = numberList.Sum();

            Console.WriteLine("the sum is " + numAdd);

            Console.ReadLine();
            
        }
    }
}
