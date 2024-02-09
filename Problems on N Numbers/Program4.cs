using System;


namespace Program4
{
    class Array
    {   
        public static void Display(int []Brr,int ilength)
        {
            int icnt = 0;
            Console.WriteLine("Your Enterd Elements:");
            for(icnt = 0; icnt < ilength; icnt++)
            {
              Console.Write(Brr[icnt]+"\t");
            }
            
        }

        public static void Main(String[] args)
        {  
            int iSize = 0;
            int icnt =0; 
            
             Console.WriteLine("Enter number of Elements:");
            iSize = Convert.ToInt32(Console.ReadLine());
             
            int []Arr = new int[iSize];

           Console.WriteLine("Enter Element:");

           
           for(icnt = 0; icnt < iSize; icnt++)
           {
              Arr[icnt] = Convert.ToInt32(Console.ReadLine());
           }

            Display(Arr,iSize) ;
        } 
    }
}