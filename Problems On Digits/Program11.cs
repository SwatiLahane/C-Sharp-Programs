//count even digits

//Difference of even and odd digits 
//input 1018 : 
//output : (8-2) : 6
//Input : 5733 (0-18)
//output : -18

using System;

namespace Digits
{
  class Program
  {
      public static int Diff(int ino)  //Function to calculate odd number
      {
          int iDigit = 0;
          int isum = 0, isum1 = 0;
          int iDiff = 0;

          
          if(ino < 0)
          {
              ino = -ino;
          }
          

          while(ino > 0)
          {
              iDigit = ino % 10;
              if(iDigit % 2 == 0)
              {
                  isum = iDigit + isum;
              }
              else
              {
                  isum1 = iDigit + isum1;
              }
                ino = ino / 10;
                iDiff = isum - isum1;

          }
          return iDiff;
      }

      //Entry point function
      public static void Main(String[] args)
      { 
          int iValue = 0;
          int iRet = 0;

          Console.WriteLine("Enter Number :");
          iValue = Convert.ToInt32(Console.ReadLine());
    
          iRet = Diff(iValue); //Function call
          Console.WriteLine("Count of Even and off difference :"+iRet);
      }
      
  }
}