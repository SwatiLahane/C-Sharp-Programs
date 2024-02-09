using System.IO;
using System;

namespace Array
{
  class NNumbers
  {
      public static void Main(String[] Args)
      {   
          int iSize = 0;
          int iCnt = 0;
          Console.WriteLine("Enter Number of elements :");
          iSize = Convert.ToInt32(Console.ReadLine());

          int []Arr = new int[iSize];
          Console.WriteLine("Enter Elements :");

          for(iCnt=0; iCnt < iSize; iCnt++)
          {
              Arr[iCnt] = Convert.ToInt32(Console.ReadLine());
          }
          
           Console.WriteLine("Elements of Array Are  :");
            for(iCnt=0; iCnt < iSize; iCnt++)
             {
                 Console.WriteLine(Arr[iCnt]); 
              }
          
      } 
  }
}