
//Swapping of two numbers without third number

using System;

namespace Swapping
{
    class Program14
    {
        public static void Main(String[] Args)
        {
            int iValue1 = 0;
            int iValue2 = 0; 
           

            Console.WriteLine("Enter First Number :");
            iValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number :"); 
            iValue2 = Convert.ToInt32(Console.ReadLine());

            iValue1 = iValue1 + iValue2;
            iValue2 = iValue1 - iValue2;
            iValue1 = iValue1 - iValue2;

            Console.WriteLine("After Swapping :"+iValue1+" "+iValue2);
        }

    }
}
