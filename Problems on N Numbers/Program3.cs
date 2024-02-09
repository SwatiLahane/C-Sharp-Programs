using System.IO;
using System;

namespace Array
{
   class Program3
   {
       public static void Main(String[] Args)
       {
           int iCnt = 0;
           int iSize = 0;

            Console.WriteLine("Enter number of Elements:");
            iSize = Convert.ToInt32(Console.ReadLine());
             
            int []Arr = new int[iSize];

           Console.WriteLine("Enter Element:");

           
           for(iCnt = 0; iCnt < iSize; iCnt++)
           {
              Arr[iCnt] = Convert.ToInt32(Console.ReadLine());
           }
           
            Console.WriteLine("Elements of Array Are :");
            for(iCnt = 0; iCnt < iSize; iCnt++)
            {
                Console.Write(Arr[iCnt]+"\t");
            }
           
       }
   }  
}