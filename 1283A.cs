using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _1283A
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, hour, munit, duration;
            T = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i< T; i++)
            {
                String line = Console.ReadLine();
                String[] array = line.Split(' ');
                hour = Convert.ToInt32(array[0]);
                munit = Convert.ToInt32(array[1]);
                duration = ((24 * 60) - (hour * 60 + munit));
                Console.Write(duration + "\n");
            }
            
        }
    }
}
