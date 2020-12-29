using System;
    class Program
    {
        static void Main(string[] args)
        {
            int N, K, count = 0, i;
            String line, line2;
            line = Console.ReadLine();
            String []str1 = line.Split(' ');
            N = Convert.ToInt32(str1[0]);
            K = Convert.ToInt32(str1[1]);
 
            line2 = Console.ReadLine();
            String[] str2 = line2.Split(' ');
            int []array= new int[N];
            for (i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(str2[i]);
            }
 
            for (i = 0; i < N; i++)
            {
                if(array[i]>0 && array[K-1] <= array[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
           
        }
    }
 
