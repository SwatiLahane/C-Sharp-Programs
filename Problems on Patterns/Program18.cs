using System;
/*
    irow = 3  icol =3
     A   A    A   A
     B   B    B   B
     C   C    C   C 

*/

namespace Patterns
{
    class  Program15
    {
        public static void Main(String[] Args)
        {
            int i = 0;
            int j = 0;
            char ch = '\0' ;
            
            Console.WriteLine("Enter Number of rows:");
            int iRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Colms:");
            int iCol = Convert.ToInt32(Console.ReadLine());
            
            for(i = 1,ch='A'; i <=iRow; i++ ,ch++)
            {
                for(j=1 ; j <= iCol; j++)
                {   
                    
                    {
                        Console.Write(ch);
                    }
                    
                }
                Console.WriteLine();
            }


        }
    }
}