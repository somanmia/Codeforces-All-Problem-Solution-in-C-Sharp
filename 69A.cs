using System;
 
 
    class Program
    {
        static void Main(string[] args)
        {
            int N, sum1=0, sum2=0, sum3=0, x, y, z;
            N = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<= N; i++)
            {
                String line = Console.ReadLine();
                String[] array = line.Split(' ');
                x = Convert.ToInt32(array[0]);
                y = Convert.ToInt32(array[1]);
                z = Convert.ToInt32(array[2]);
                sum1 += x;
                sum2 += y;
                sum3 += z;
            }
            if(sum1==0 && sum2==0 && sum3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
 
