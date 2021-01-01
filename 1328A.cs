using System;
    class Program
    {
        static void Main(string[] args)
        {
            int i,N, count,a,b,result;
            string userinput;
            N = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<= N; i++)
            {
              
                userinput = Console.ReadLine();
                String[] line = userinput.Split(' ');
                a = Convert.ToInt32(line[0]);
                b = Convert.ToInt32(line[1]);
           
                
                    if (a % b == 0)
                    {
                        Console.WriteLine("0");
                        
                    }
                    else
                    {
                        result=b-(a%b);
                        Console.WriteLine(""+result);
                    }
 
                   
                
                
            }
       
        }
    }
