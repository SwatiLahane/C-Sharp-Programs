//Accept N numbers and accept one another number from user and check that is present or not

using System;


namespace Program4
{
    class Array
    {   
        public static bool checkNumber(int []Brr,int ilength,int iNo)
        {
            int icnt = 0;
            int isum = 0;
          
            for(icnt = 0; icnt < ilength; icnt++)
            {
               if(Brr[icnt] == iNo)
               {
                   return true;
               }

            }

            return  false;
            
        }



        public static void Main(String[] args)
        {  
            int iSize = 0;
            int icnt = 0; 
            bool bret = false;
            int iNo = 0;
            
             Console.WriteLine("Enter number of Elements:");
            iSize = Convert.ToInt32(Console.ReadLine());
             
            int []Arr = new int[iSize];

           Console.WriteLine("Enter Element:");

           
           for(icnt = 0; icnt < iSize; icnt++)
           {
              Arr[icnt] = Convert.ToInt32(Console.ReadLine());
           }
           
            Console.WriteLine("Enter another number :");
            iNo = Convert.ToInt32(Console.ReadLine());

            bret = checkNumber(Arr,iSize,iNo) ;

            if(bret == true )
            {
              Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("Number is not present");
            }
            
        } 
    }
}