/* Online C# Compiler and Editor */
using System.IO;

using System;

namespace OddNumber
{
 
  class  Program12
  {
     public static bool Even(int iValue)
     {
         if(iValue % 2 == 0)
        {
          return true;
        }   
        else 
        {
          return false;
        }   

     }   
     //Entry point function

     public static void Main(String[] Args)
     {

        int iNo = 0;   //local variabels
        bool bRet = false; //local variables

        Console.WriteLine("Enter Number :");
        iNo = Convert.ToInt32(Console.ReadLine());
         
         bRet = Even(iNo); //Function call

         if(bRet == true)
         {
              Console.WriteLine("Number is Odd");
         }
        else
        {
            Console.WriteLine("Number is not Odd");
        }

  
     }

  }

}
