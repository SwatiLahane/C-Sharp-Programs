
//Sum Digits



using System;

namespace Digits
{
  class Program
  {
      public static int SumDigits(int ino)  //Function to calculate odd number
      {
          int isum = 0;
          int iDigit =0;
          
          
          if(ino < 0)
          {
              ino = -ino;
          }
          

          while(ino > 0)
          {
              iDigit = ino % 10;
              isum = iDigit + isum;
             
             ino = ino / 10;
          }
          return isum;
      }

      //Entry point function
      public static void Main(String[] args)
      { 
          int iValue = 0;
          int iRet = 0;

          Console.WriteLine("Enter Number :");
          iValue = Convert.ToInt32(Console.ReadLine());
    
          iRet = SumDigits(iValue); //Function call
          Console.WriteLine("Sum of Digits are :"+iRet);
      }
      
  }
}