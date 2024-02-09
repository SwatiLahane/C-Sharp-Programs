

//Print Hello 5 times

using System.IO;

using System;

namespace JayGanesh
{     
     class Program17
     { 
       public static void Display(int iNo)
       {
            
           //1            2            3
            while(iNo > 0)  //Loop
            { 
              Console.Write("*\t"); //4
              iNo--;
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
