using System;

namespace lab2visual
{
    class Program
    {
        static void Main()
        {
            RomanNumber n1 = new((ushort)437);
            RomanNumber n2 = new((ushort)2);
            Console.WriteLine("437 = " + n1);
            Console.WriteLine("2 = " + n2);
            Console.WriteLine("437 + 2 = " + (n1 + n2));
            Console.WriteLine("437 - 2 = " + (n1 - n2));
            Console.WriteLine("437 * 2 = " + (n1 * n2));
            Console.WriteLine("437 / 2 = " + (n1 / n2)); 
            
            short[] Values = new short[]
            { 9, 6, 5, 4, 3, 2, 1 };
            RomanNumber[] romanArray = new RomanNumber[Values.Length];
            Console.WriteLine("Array:");
            for (int i = 0; i < Values.Length; ++i)
            {
                romanArray[i] = new RomanNumber(((ushort)Values[i]));
                Console.Write(Values[i] + "(" + romanArray[i].ToString() + ")" + " ");
            }
            Console.WriteLine("\nSorted Array:");
            Array.Sort(romanArray);
            Array.Sort(Values);
            for (int i = 0; i < Values.Length; ++i)
            {
                Console.Write(Values[i] + "(" + romanArray[i].ToString() + ")" + " ");
            }
        }
    }
}
