using System;

//irow = 4 iCol = 4
/*
       a   b  c  d  
       A   B  C  D
       a   b  c  d  
       A   B  C  D


*/

namespace Patterns
{
    class  Program15
    {
        public static void Main(String[] Args)
        {
            int i = 0;
            int j = 0;
            char ch = '\0' , ch1 ='\0';
            
            Console.WriteLine("Enter Number of rows:");
            int iRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Colms:");
            int iCol = Convert.ToInt32(Console.ReadLine());
            
            for(i = 1; i <=iRow; i++ )
            {
                for(j=1,ch='A',ch1 = 'a'; j <= iCol; j++,ch++,ch1++)
                {   
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(ch);
                    }
                    
                    else
                    {
                        Console.WriteLine(ch1);
                    }
                  
                }
            }


        }
    }
}