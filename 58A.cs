using System;
 
    class Program
    {
        static void Main(string[] args)
        {
        String str = "hello";
        String str2 = Console.ReadLine();
        int i, count = 0, x = 0;
        for (i = 0; i < str2.Length; i++)
        {
            String y = str2.Substring(i, 1);
            String z = str.Substring(x,1);
            if (y.Equals(z))
            {
                x++;
                count++;
            }
            if (count == 5)
            {
                break;
            }
        }
        if (count == 5)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
 
        }
 
 
           
 
        }
    }
