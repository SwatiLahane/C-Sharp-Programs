//count even digits

using System;

namespace Digits
{
  class Program
  {
      public static int CountEven(int ino)
      {
          int iDigit = 0;
          int iCnt = 0;

          while(ino > 0)
          {
              iDigit = ino % 10;
              if(iDigit % 2 == 0)
              {
                  iCnt++;
              }
              ino = ino / 10;
          }
          return iCnt;
      }
      public static void Main(String[] args)
      { 
          int iValue = 0;
          int iRet = 0;

          Console.WriteLine("Enter Number :");
          iValue = Convert.ToInt(Console.ReadLine());
    
          iRet = CountDigit(iValue);
          Console.WriteLine("Count of Even Digits :"+iRet);
      }
      
  }
}