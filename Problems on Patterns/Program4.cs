
// //input 5
//Output # 1 * #  2 * # 3 * #  4  * #  5  *


using System;
namespace Program1 
{
    class Pattern
    {
         public static void Main(String[] args)
         {
             
             int icnt = 0;
             Console.WriteLine("Enter Number:");
             int iNo =  Convert.ToInt32(Console.ReadLine());

             for(icnt = 1; icnt <= iNo; icnt++)
             {
                 Console.Write(icnt*2 + "\t");
             }
         }
    }
}