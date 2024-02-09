using System;


namespace Program4
{
    class Array
    {   
        public static int Addition(int []Brr,int ilength)
        {
            int icnt = 0;
            int isum = 0;
            Console.WriteLine("Addition of All the elements:");
            for(icnt = 0; icnt < ilength; icnt++)
            {
               isum = Brr[icnt] + isum;
            }

            return isum;
            
        }



        public static void Main(String[] args)
        {  
            int iSize = 0;
            int icnt = 0; 
            int iret = 0;
            
             Console.WriteLine("Enter number of Elements:");
            iSize = Convert.ToInt32(Console.ReadLine());
             
            int []Arr = new int[iSize];

           Console.WriteLine("Enter Element:");

           
           for(icnt = 0; icnt < iSize; icnt++)
           {
              Arr[icnt] = Convert.ToInt32(Console.ReadLine());
           }

            iret = Addition(Arr,iSize) ;
            Console.WriteLine("Addition of Array Elements are :"+iret);
        } 
    }
}