using System;


    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 0;
            n = Convert.ToInt32(Console.ReadLine());
            char[] array = Console.ReadLine().ToCharArray();

            for (int i = 0; i < n-1; i++) {
                if (array[i] == array[i + 1])
                {
                    count++;
                }


            }
            Console.WriteLine("" + count);

            
        }
    }

