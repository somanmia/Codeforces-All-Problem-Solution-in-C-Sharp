using System;
    class Program
    {
        static void Main(string[] args)
        {
        int num = Convert.ToInt32(Console.ReadLine());
        if(num%4==0 || num%7==0 || num%47==0 || num%74==0 || num%444==0 ||  num%474==0 || num%447==0 || num%477==0|| num%777==0 || num%747==0 || num % 774 == 0 || num%744==0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
       
        }
    }
 
