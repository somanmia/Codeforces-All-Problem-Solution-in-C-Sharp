using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _617A
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("{0}", num / 5);
            }
            else
            {
                Console.WriteLine("{0}", (num / 5) + 1);
            }
 
           
        }
    }
}
