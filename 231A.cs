using System;
 
    class Program
    {
        static void Main(string[] args)
        {
            int i, win = 0, x, y, z,N;
            N = Convert.ToInt32(Console.ReadLine());
            for(i=0;i< N; i++)
            {
                String input = Console.ReadLine();
                String []str = input.Split(' ');
                x = Convert.ToInt32(str[0]);
                y = Convert.ToInt32(str[1]);
                z = Convert.ToInt32(str[2]);
 
                if((x==1 && y==1 && z==1) || (x==1 && y==1)|| (x==1 && z==1) || (y==1 && z == 1))
                {
                    win++;
                }
                
            }
            Console.WriteLine(win);
 
        }
    }
