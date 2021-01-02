using System;
 
    class Program
    {
        static void Main(string[] args)
        {
            int uppercase = 0; int lowercase = 0;
            String userinput = Console.ReadLine();
            char[] ch = userinput.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 65 && ch[i] >= 91)
                {
                    lowercase++;
                }
                else
                {
                    uppercase++;
                }
            }
 
 
            if (lowercase > uppercase)
            {
                Console.WriteLine("" + userinput.ToLower());
 
            }
           else  if (lowercase < uppercase)
            {
                Console.WriteLine("" + userinput.ToUpper());
 
            }else
            {
                Console.WriteLine("" + userinput.ToLower());
            }
 
 
           
        }
    }
