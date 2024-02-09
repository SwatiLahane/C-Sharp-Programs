

//Accept N numbers from user and display range between that nubers

using System;


namespace Program4
{
    class Array
    {   
        public static void RangeDisplay(int []Brr,int ilength,int ino1,int ino2)
        {
            int icnt = 0;
            
          
            for(icnt = 0; icnt < ilength; icnt++)
            {
               
               {
                   if(Brr[icnt] >= ino1 && Brr[icnt] <= ino2 )
                   {
                       Console.WriteLine(Brr[icnt]+"\t");
                   }
               }

            }

            
            
        }



        public static void Main(String[] args)
        {  
            int iSize = 0;
            int icnt = 0; 
            int iret = 0;
            int istart = 0 ,iend = 0;
           
            
             Console.WriteLine("Enter number of Elements:");
            iSize = Convert.ToInt32(Console.ReadLine());
             
            int []Arr = new int[iSize];

           Console.WriteLine("Enter Element:");

           
           for(icnt = 0; icnt < iSize; icnt++)
           {
              Arr[icnt] = Convert.ToInt32(Console.ReadLine());
           }
           
            Console.WriteLine("Enter Start Range :");
            istart = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end Range :");
            iend = Convert.ToInt32(Console.ReadLine());
            
            iret = RangeDisplay(Arr,iSize,istart,iend) ;

           
            
        } 
    }
}