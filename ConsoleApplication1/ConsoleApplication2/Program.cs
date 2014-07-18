using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //have the user pick a number from 1-20
            var numbers = new List<int>() { 9, 8, 12, 11, 4, 3, 17, 13, 20 };


            Console.WriteLine("Pick a number between 1 and 20");
            int userInput = int.Parse(Console.ReadLine());


            var comp = numbers.Contains(userInput);

           if (comp)
           {
               Console.WriteLine("Hooray! You're correct! :-) ");
               Console.ReadLine();
           }
            

           else
           {
               Console.WriteLine("Oh Noooooo! Wrong number :-(");
               Console.ReadLine();
           }



          
        }
    }
}
