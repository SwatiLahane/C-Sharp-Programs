
//Check whether Number contains zero or not


//Accept number from user and display its digits in reverse
using System;

namespace Digits
{ 
  class Program2
  { 
     public static bool CheckZero(int iNo)
     {
         while(iNo > 0)
         {
             int iDigit = 0;
             iDigit = iNo % 10;
             if(iDigit == 0)
             {
                 return true;
             }
            
        
           iNo = iNo / 10;
         }  

           return false;
            

            
     } 
      public static void Main(String[] Args)
     {
         int iValue = 0;
         bool bRet = false;
         Console.WriteLine("Enter Number :");
         iValue = Convert.ToInt32(Console.ReadLine());
         
          bRet = CheckZero(iValue);
        if(bRet == true)
        {
             Console.WriteLine("Number Contains Zero");
        }
        else
        {
            Console.WriteLine("Number not Contains Zero");
        }
     }

     }
  }
    
}