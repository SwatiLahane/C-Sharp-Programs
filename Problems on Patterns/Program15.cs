
using System.IO;
using System;

namespace Prattern
{
     class Program
     {
        public static void Main(String[] args)
        {
           int i = 0;
            int j = 0;

             Console.WriteLine("Enter Number of rows:");
             int iRow =  Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Enter Number of colms:");
              int iCol =  Convert.ToInt32(Console.ReadLine());
               //1          2       3
             for(i = 1; i <= iRow; i++) //Outer loop
             { 
                for(j = 1; j<= iCol; j++) //inner loop
                {
                        if(iRow+1-i) //4
                        {
                            Console.Write("#" +"\t");   
                        }
                        else
                        {
                            Console.Write("*" +"\t");     
                        }
                       
                }
                 Console.WriteLine("\n");
             } 
        }
     }
}