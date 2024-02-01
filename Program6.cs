 using System;

//Addition of two numbers 
namespace HelloWorld
{
  class Program
  {
  
    static void Main(string[] args)
    { 
       

     int iNo1 = 0;
     int iNo2 = 0;
     int iAns = 0;
     iAns = iNo1 + iNo2;
     
     Console.WriteLine("Enter number first:");
     iNo1 = Convert.ToInt32(Console.ReadLine());
     
     Console.WriteLine("Enter Number second:");
     iNo2 = Convert.ToInt32(Console.ReadLine());
     
     iAns = iNo1 + iNo2;
     Console.WriteLine("Addition is :"+iAns);
     

    }
  }
}