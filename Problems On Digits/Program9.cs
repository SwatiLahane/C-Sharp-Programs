//count odd digits
//Count digits betwwen 3 and 7

using System;

namespace Digits
{
  class Program
  {
      public static int CountDigitsBet(int ino)  //Function to calculate odd number
      {
          int iDigit = 0;
          int iCnt = 0;
          
          if(ino < 0)
          {
              ino = -ino;
          }
          

          while(ino > 0)
          {
              iDigit = ino % 10;
              if(iDigit >= 3 && iDigit <= 7)
              {
                  iCnt++;
              }
              ino = ino / 10;
          }
          return iCnt;
      }
      //Entry point function
      public static void Main(String[] args)
      { 
          int iValue = 0;
          int iRet = 0;

          Console.WriteLine("Enter Number :");
          iValue = Convert.ToInt32(Console.ReadLine());
    
          iRet = CountDigitsBet(iValue); //Function call
          Console.WriteLine("Count of  Digits between 3 and 7:"+iRet);
      }
      
  }
}