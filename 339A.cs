using System;
    class Program
    {
        static void Main(string[] args)
        {
            String x = Console.ReadLine();
            char []array = x.ToCharArray();
            for(int i = 0; i < array.Length; i=i+2)
            {
                for(int j = 0; j < array.Length - 1; j=j+2)
                {
                    if (array[j] > array[j + 2])
                    {
                        char temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
                    }
                }
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("" + array[i]);
            }
 
        
        }
    }
