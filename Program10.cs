using System;

namespace HelloWorld
{
    
  class Program
  {
    
    static void Main(string[] args)
    { 
     
    
     Console.WriteLine("Enter Radius first:");
     double Radius = Convert.ToDouble(Console.ReadLine());
    
     
     double Area = Math.PI * Radius * Radius;
     Console.WriteLine("Area are:"+Area);
       
     

    }
  }
}