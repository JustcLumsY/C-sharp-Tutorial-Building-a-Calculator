using System;

namespace Building_a_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //int num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(num1 + num2);
        }
    }
}
