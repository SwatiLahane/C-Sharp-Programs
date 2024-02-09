using System;
/*
     iRow = 4, iCol = 7
     
         *
      *  *  *
    * *  *  * * 
  *  *  *  * *  *


*/

namespace Patterns
{
    class  Program15
    {
        public static void Main(String[] Args)
        {
            int i = 0;
            int j = 0;
           
            
            Console.WriteLine("Enter Number of rows:");
            int iRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Colms:");
            int iCol = Convert.ToInt32(Console.ReadLine());
            
            for(i = 1; i <=iRow; i++)
            {
                for(j=1 ; j <= iCol; j++)
                {   
                    
                      if(j>=5-i && j<=3+i)
                    
                      {
                          Console.Write("*"+"\t");
                      }
                      else
                      {
                           Console.Write(" ");
                      }
                      
                }
                Console.WriteLine();
            }


        }
    }
}