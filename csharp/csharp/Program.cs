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
        static int[] array = new int[5];
        
        static void Main(string[] args)
        {
            firstClass myClass = new firstClass();
            customClass customClass = new customClass();
            //Console.Write("What you wanna do?");
            //string choice = Console.ReadLine();
            //float a = 0;
            //float b = 0;
            //float c = 0;
            //
            //switch (choice)
            //{
            //    case "+":
            //        Console.Write("Enter 2 numbers");
            //        Console.WriteLine("");
            //        a = Convert.ToSingle(Console.ReadLine());
            //        b = Convert.ToSingle(Console.ReadLine());
            //        c = myClass.Addition(a, b);
            //        Console.WriteLine(a + " plus " + b + " is " + c);
            //        break;
            //    case "-":
            //        Console.Write("Enter 2 numbers");
            //        Console.WriteLine("");
            //        a = Convert.ToSingle(Console.ReadLine());
            //        b = Convert.ToSingle(Console.ReadLine());
            //        c = myClass.Subtraction(a, b);
            //        Console.WriteLine(a + " minus " + b + " is " + c);
            //        break;
            //
            //    case "/":
            //        Console.Write("Enter 2 numbers");
            //        Console.WriteLine("");
            //        a = Convert.ToSingle(Console.ReadLine());
            //        b = Convert.ToSingle(Console.ReadLine());
            //        c = myClass.Division(a, b);
            //        Console.WriteLine(a + " divided by " + b + " is " + c);
            //        break;
            //
            //    case "*":
            //        Console.Write("Enter 2 numbers");
            //        Console.WriteLine("");
            //        a = Convert.ToSingle(Console.ReadLine());
            //        b = Convert.ToSingle(Console.ReadLine());
            //        c = myClass.Multiplication(a, b);
            //        Console.WriteLine(a + " multiplied by " + b + " is " + c);
            //        break;
            //
            //    default:
            //        Console.WriteLine("That's not a function");
            //
            //        break;
            //
            //}

            //ArrayExample(10);
            //Console.WriteLine("Array Copy");
            //ArrayExample2(array);
            //array[4] = 10;
            //Console.WriteLine("");
            //Console.WriteLine("Original Array");
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
            myClass.ListExample();
            

            while (true) ;
        }

    }


}
