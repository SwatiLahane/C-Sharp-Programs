
// //input irow = 4 , icol = 3
 /*
 
    #	#	#	#	

    *	*	*	*	

    #	#	#	#	

    *	*	*	*	


*/


using System;
namespace Program1 
{
    class Pattern
    {
         public static void Main(String[] args)
         {
             
            int i = 0;
            int j = 0;

             Console.WriteLine("Enter Number of rows:");
             int iRow =  Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Enter Number of colms:");
              int iCol =  Convert.ToInt32(Console.ReadLine());

             for(i = 1; i <= iRow; i++) //Outer loop
             { 
                for(j = 1; j<= iCol; j++) //inner loop
                {
                        if(i % 2 == 0)
                        {
                            Console.Write("*" +"\t");   
                        }
                        else
                        {
                            Console.Write("#" +"\t");     
                        }
                       
                }
                 Console.WriteLine("\n");
             } 
         }
    }
}