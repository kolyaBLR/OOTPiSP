using System;
using System.Collections.Generic;

namespace OOTPiSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector obj1 = new Vector();
            obj1.Vector = new List<int>() { 0, 2 ,12, 7};
            Vector obj2 = new Vector();
            obj2.Vector = new List<int>() {5, 3, 67, 2, -4, 9};
            Vector obj = obj1 + obj2;
            Print(obj);
            obj.Sort();
            Print(obj);
            Swap(obj);
            Print(obj);
        }

        static void Print(Vector obj)
        {
            for (int i = 0; i < obj.Vector.Count; i++)
                Console.Write("{0} ", obj.Vector[i]);
            Console.WriteLine();
        }

        static void Swap(params Vector[] arrayObj)
        {
            int min = 0, max = 0, arrayMin = 0, arrayMax = 0;
            for (int i = 0; i < arrayObj.Length; i++)
            {
                for (int j = 0; j < arrayObj[i].Vector.Count; j++)
                {
                    if (arrayObj[i].Vector[j] > arrayObj[arrayMax].Vector[max])
                    {
                        max = j;
                        arrayMax = i;
                    }
                    else
                    if (arrayObj[i].Vector[j] < arrayObj[arrayMin].Vector[min])
                    {
                        min = j;
                        arrayMin = i;
                    }
                }
            }
            int swap = arrayObj[arrayMax].Vector[max];          
            arrayObj[arrayMax].Vector[max] = arrayObj[arrayMin].Vector[min];
            arrayObj[arrayMin].Vector[min] = swap;
        }
    }
}