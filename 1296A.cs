using System;
 
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum, N, size,j,even,odd;
            String userinput;
            N = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= N; i++) {
                size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                userinput = Console.ReadLine();
                String[] str = userinput.Split(' ');
                 sum = 0;
                 even =0;
                 odd = 0;
                for (j=0;j< size; j++)
                {             
                    array[j] = Convert.ToInt32(str[j]);
                    if(array[j]%2!=0 || array[j] == 1)
                  {
                    odd++;
                }
                else
                {
                    even++;
                }
                sum = sum + array[j];
                }
                if(sum%2!=0 || sum == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                if(odd!=0 && even != 0)
                {
 
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
 
              
 
            }
 
            
 
        }
    }
 
