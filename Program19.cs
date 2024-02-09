
//Check whether number is divisible by 5 or not
using System.IO;

using System;

namespace Check
{
 class  Divisible
 {
    public static bool Check(int iNo)
    {
        if(iNo % 5 == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    } 
     public static void Main(String[] Args)
    {
       int iValue = 0;
       bool bRet = false;

       Console.Write("Enter Number:");
       iValue = Convert.ToInt32(Console.ReadLine());

       bRet = Check(iValue);
       if(bRet = true)
       {
           Console.WriteLine("Divisible by 5");
       }

       else
       {
           Console.WriteLine("Not Divisible by 5");
       }
    }  

  }    
}