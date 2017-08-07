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
        static void ArrayExample(int size)
        {
            int[] array = new int[size];
            foreach (int index in array)
            {
                //index = 1;  cant change variable in foreach loop
                Console.WriteLine(array[index]);
            }
        }

        static int[] array = new int[69];
        static void ArrayExample2(int[] array)
        {
            Array ar = array;
            int length = ar.Length;
            Console.WriteLine(length);
        }

        enum choices
        {
            Add = '+',
            Subtract = '-',
            Multiply = '*',
            Divide = '/',
        }


        static void Main(string[] args)
        {
            //firstClass myClass = new firstClass();
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
            ArrayExample2(array);
            Console.WriteLine(array[100]);
            while (true) ;
        }

    }


}
