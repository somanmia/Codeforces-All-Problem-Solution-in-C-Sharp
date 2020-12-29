
using System;
 
    class Program
    {
        static void Main(string[] args)
        {
        int N, i;
        N = Convert.ToInt32(Console.ReadLine());
        String str;
        for (i = 0; i < N; i++)
        {
            str = Console.ReadLine();
            if (str.Length > 10)
            {
                String fchar = str.Substring(0, 1);
                String lchar = str.Substring(str.Length - 1, 1);
                Console.WriteLine("{0}{1}{2}", fchar, str.Length - 2, lchar);
            }
            else
            {
                Console.WriteLine("" + str);
            }
        }
 
 
        }
    }
