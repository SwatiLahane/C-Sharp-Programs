
/*
*	*	*	*	
*	*	    *	
*	    *	*	
*	*	*	*	

*/

using System;

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
                    
                      if((i == j)||(i == 1) || (j == 1) || (i == iRow) || (j == iCol))
                      {
                        Console.Write("*"+"\t");
                      }
                      else
                      {
                          Console.Write("@"+"\t");
                      }
                }
                Console.WriteLine();
            }


        }
    }
}