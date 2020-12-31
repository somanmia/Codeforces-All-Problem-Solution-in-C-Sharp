using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _41A
{
    class Program
    {
        static void Main(string[] args)
        {
            string newstr="";
            string s = Console.ReadLine();
            String t = Console.ReadLine();
            int len = t.Length;
            for(int i=1;i<=len; i++)
            {
               newstr=newstr+ t.Substring(len-i,1);
            }
            if (s.Equals(newstr))
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
