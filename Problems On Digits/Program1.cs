
//Accept number from user and display its digits in reverse
using System;

namespace Digits
{ 
  class Program1
  { 
     public static void Reverse(int iNo)
     {
         while(iNo > 0)
         {
             int iDigit = 0;
             iDigit = iNo % 10;
             Console.WriteLine(+iDigit);
         }   iNo = iNo / 10;
            
     } 
      public static void Main(String[] Args)
     {
         int iValue = 0;

         
         Console.WriteLine("Enter Number :");
         iValue = Convert.ToInt32(Console.ReadLine());
         
         Reverse(iValue);


     }
  }
    
}