
//Swapping of two numbers 

using System;

namespace Swapping
{
    class Program14
    {
        public static void Main(String[] Args)
        {
            int iValue1 = 0;
            int iValue2 = 0; 
            int iTemp = 0;


            Console.WriteLine("Enter First Number :");
            iValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number :"); 
            iValue2 = Convert.ToInt32(Console.ReadLine());

            iTemp = iValue1;
            iValue1 = iValue2;
            iValue2 = iTemp;

            Console.WriteLine("After Swapping :"+iValue1+" "+iValue2);
        }

    }
}
