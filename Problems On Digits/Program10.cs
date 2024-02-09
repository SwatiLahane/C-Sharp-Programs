//count odd digits
// Multiplication of digits
using System;

namespace Digits
{
  class Program
  {
      public static int DigitMul(int ino)  //Function to calculate odd number
      {
          int iDigit = 0;
          int iCnt = 0;
          
          if(ino < 0)
          {
              ino = -ino;
          }
          

          while(ino > 0)
          {    
              int imul = 1;
              iDigit = ino % 10;
              imul = imul * iDigit;
              ino = ino / 10;
          }
         return imul;
      }
      //Entry point function
      public static void Main(String[] args)
      { 
          int iValue = 0;
          int iRet = 0;

          Console.WriteLine("Enter Number :");
          iValue = Convert.ToInt32(Console.ReadLine());
    
          iRet =  DigitMul(iValue); //Function call
          Console.WriteLine("Count of Multiplication of Digits :"+iRet);
      }

      
  }
}