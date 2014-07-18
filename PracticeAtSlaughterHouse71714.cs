using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceAtSlaughterHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>() { 83, 76, 12, 8, 22, 4, 6, 76, 54, 58 };
            //create a list of integers, fill with number 1-100use linq to find largest value in the list and display in console
            foreach (var item in num) { Console.WriteLine(item); }
            var BigOne = num.Max();

            

            Console.WriteLine("The largest number is {0}", BigOne);
            Console.ReadLine();



////
        }



			
}

}

