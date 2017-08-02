using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csharp
{
    class Program
    {
        enum choices{
            Add = '+', 
            Subtract = '-',
            Multiply = '*', 
            Divide = '/',
        }


        static void Main(string[] args)
        {
            firstClass myClass = new firstClass();
            //Console.Write("What's ur name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("hi, " + name);
            Console.Write("What you wanna do?");
            //Console.WriteLine();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "asd":
                    Console.WriteLine("asdddedasdfasdfasdf");



                    break;
                case "anything else":
                    Console.WriteLine("AnythingBlahhh");



                    break;

                default:
                    Console.WriteLine("Nothing matched the case");

                    break;

            }
            
            while (true) ;
        }
        
    }
}
