using System;
namespace _271
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, a, b, c, d;
            num = Convert.ToInt32(Console.ReadLine());
            for (;;)
            {
                num++;
                temp = num;
                a = temp % 10;
                temp = temp / 10;
 
                b = temp % 10;
                temp = temp / 10;
 
                c = temp % 10;
                temp = temp / 10;
 
                d = temp % 10;
                
               if(a!=b && a!=c && a!=d && b!=c && b!=d && c != d)
                {
                    Console.Write("{0}\n", num);
                    break;
                }
 
            }
           
 
 
 
 
            
        }
    }
}
 
