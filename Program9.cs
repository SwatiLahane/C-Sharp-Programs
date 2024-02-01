

//Additon different ways to solve problems

using System;

namespace HelloWorld
{

 public class Arithematic
  {
       private 
       int iValue1;
       int iValue2;
       
       public Arithematic(int A, int B)
       {
           iValue1 = A;
           iValue2 = B;
       }
       
      public int Addition()
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
     
     Arithematic aobj = new Arithematic(iNo1,iNo2);
     iRet = aobj.Addition();
     Console.WriteLine("Addition is :"+iRet);

    }
  }
}