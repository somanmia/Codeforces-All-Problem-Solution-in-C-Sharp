using System;
namespace _155A
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,i,j,count=0;
            N = Convert.ToInt16(Console.ReadLine());
            int []array = new int[N];
            String userinput = Console.ReadLine();
            String []r = userinput.Split(' ');
            for(i=0;i< N; i++)
            {
                array[i] = Convert.ToInt32(r[i]);
            }
            int max = array[0];
            int min = array[0];
            for (j = 0; j < array.Length; j++)
            {
                if (max < array[j])
                {
                    max = array[j];
                    count++;
                }else if (min > array[j])
                {
                    min = array[j];
                    count++;
                }
            }
            Console.Write("{0}\n", count);
          
        }
    }
}
