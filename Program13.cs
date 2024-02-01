
//Calculate faactors 
using System.IO;

using System ;

namespace OddNumber
{
 
  class  Program12
  {
     public static int  Factors(int iValue)
     {
        int iCnt = 0;
        int iFact = 1;
         for( iCnt = 1; iCnt <= iValue; iCnt++)
         {
           iFact = iCnt * iFact;
         }
         
         return iFact;
     }   
     //Entry point function

     public static void Main(String[] Args)
     {

        int iNo = 0;   //local variabels
        int iRet = 0; //local variables

        Console.WriteLine("Enter Number :");
        iNo = Convert.ToInt32(Console.ReadLine());
         
         iRet = Factors(iNo); //Function call
         
         Console.WriteLine("Factors Are :"+iRet);
        
     }

  }

}
