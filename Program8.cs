
//Addition program 

using System;

namespace HelloWorld
{

 class Arithematic
  {
       
       
      public int Addition(int iValue1, int iValue2)
       {
           int Result = 0;
        Result = iValue1 +  iValue2;
        return  Result;
        
       }
        
    
  }
    
    
  class Program
  {
    
    static void Main(string[] args)
    { 
       

     int iNo1 = 0;
     int iNo2 = 0;
     
     int iRet = 0;
     
     
     Console.WriteLine("Enter number first:");
     iNo1 = Convert.ToInt32(Console.ReadLine());
     
     Console.WriteLine("Enter Number second:");
     iNo2 = Convert.ToInt32(Console.ReadLine());
     
     Arithematic aobj = new Arithematic();
     iRet = aobj.Addition(iNo1,iNo2);
     Console.WriteLine("Addition is :"+iRet);

    }
  }
}