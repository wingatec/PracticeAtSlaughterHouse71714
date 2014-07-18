using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a sentence and reverse it in the console


            var sentence = new List<string>() { "Print", "this", "backwards" };

            foreach (var item in sentence) { Console.Write(item+" "); }

            sentence.Reverse();

            Console.WriteLine();

            foreach (var item in sentence) { Console.Write(item + " "); }
                
         
            

           // Console.WriteLine(sentence);
            Console.ReadLine();





        }
    }
}
