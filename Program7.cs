 using System;

namespace HelloWorld
{
  class Program
  {
    static int Addition(int iValue1, int iValue2)
    {   
        int Result = 0;
        Result = iValue1 +  iValue2;
        return  Result;
        
    }
    static void Main(string[] args)
    { 
       

     int iNo1 = 0;
     int iNo2 = 0;
     
     int iRet = 0;
     
     
     Console.WriteLine("Enter number first:");
     iNo1 = Convert.ToInt32(Console.ReadLine());
     
     
     Console.WriteLine("Enter Number second:");
     iNo2 = Convert.ToInt32(Console.ReadLine());
     
     iRet = Addition(iNo1, iNo2);
     Console.WriteLine("Addition is :"+iRet);

    }
  }
}