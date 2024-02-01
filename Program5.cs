

using System;

namespace Addiion
{
    class Program4
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the first Number :");
            int iNo1 = Convert.ToInt32(Console.Readline());

            Console.WriteLine("Enter Second Number :");
            int iNo2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\Sum of two numbers are = {0} :", iNo1 + iNo2 );
            
        }
    }
}