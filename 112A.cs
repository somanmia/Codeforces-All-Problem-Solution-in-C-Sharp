using System;
 
    class Program
    {
        static void Main(string[] args)
        {
        String x = Console.ReadLine().ToLower();
        String y = Console.ReadLine().ToLower();
        if (x.Equals(y))
        {
            Console.WriteLine("0");
        }else if (x.CompareTo(y) > 0)
        {
            Console.WriteLine("1");
        }else if (x.CompareTo(y) < 0)
        {
            Console.WriteLine("-1");
        }
       
        }
    }
