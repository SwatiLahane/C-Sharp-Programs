

//Print Hello 5 times

using System.IO;

using System;

namespace JayGanesh
{     
     class Program17
     { 
       public static void Display(int iNo)
       {
             int iCnt = 0;
           //1            2            3
            for(iCnt = 0; iCnt <= iNo; iCnt++)  //Loop
            { 
              Console.Write("*\t"); //4
            }
       }

       public static void Main(String[] Args)
       {    
           int iValue = 0;
          

           Console.WriteLine("Enter How many times u want to print jay ganesh on screen");
           iValue = Convert.ToInt32(Console.ReadLine());
           
           Display(iValue);
              
            
            
       }  
       
     }


}
