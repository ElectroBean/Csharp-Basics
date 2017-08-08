using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class firstClass
    {
        public float Addition(float n1, float n2)
        {
            return (n1 + n2);
        }

        public float Division(float n1, float n2)
        {
            return (n1 / n2);
        }

        public float Multiplication(float n1, float n2)
        {
            return n1 * n2;
        }

        public float Subtraction(float n1 , float n2)
        {
            return n1 - n2;
        }

        public void ListExample()
        {
            List<int> myList = new List<int>() {3, 5, 2, 9};
            myList.Add(10);
            myList.Add(1);
            myList[4] = 3;
            myList.Remove(4);
            myList.Remove(3);
            //myList[8] = 2;
            myList.Sort();
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }

        public void ArrayExample2(int[] array)
        {
            Array ar = array;
            int length = ar.Length;
            // Console.WriteLine(length);

            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
        }

        public void ArrayExample(int size)
        {
            int[] array = new int[size];
            foreach (int index in array)
            {
                //index = 1;  cant change variable in foreach loop
                Console.WriteLine(array[index]);
            }
        }


    }
}
