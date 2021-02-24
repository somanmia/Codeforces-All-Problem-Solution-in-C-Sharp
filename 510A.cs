using System;
namespace _510A
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M,row,col;
            String userinput = Console.ReadLine();
            String[] line = userinput.Split(' ');
            N = Convert.ToInt32(line[0]);
            M = Convert.ToInt32(line[1]);
            for(row=1;row<= N; row++)
            {
                for(col=1;col<= M; col++)
                {
                    if (row % 2 == 0)
                    {
                                if (row % 4 == 0)
                        {
                                            if (col == 1)
                                            {
                                                Console.Write("#");
                            }else
                            {
                                Console.Write(".");
                            }
                        }
                        else if (row % 4 != 0)
                                {
                                        if (col == M)
                                        {
                                            Console.Write("#");
                            }else
                            {
                                Console.Write(".");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("\n");
            }
            
        }
    }
}
