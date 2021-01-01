using System;
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for(int i=0; i< N; i++)
            {
                string s = Console.ReadLine();
                char []ch = s.ToCharArray();
                if (ch[1] == '-')
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }
 
            Console.WriteLine("" + x);
          
        }
    }
