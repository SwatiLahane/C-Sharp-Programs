using System;

/*
        A	B	C	D	E	
        A	B	C	D	E	
        A	B	C	D	E	
        A	B	C	D	E	
        A	B	C	D	E	
*/


namespace Patterns
{
    class  Program15
    {
        public static void Main(String[] Args)
        {
            int i = 0;
            int j = 0;
            char ch = '\0';
            Console.WriteLine("Enter Number of rows:");
            int iRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Colms:");
            int iCol = Convert.ToInt32(Console.ReadLine());
            
            for(i = 1; i <=iRow; i++ )
            {
                for(j=1,ch='A'; j <= iCol; j++,ch++;)
                {
                    Console.WriteLine(ch);
                    
                }
            }


        }
    }
}