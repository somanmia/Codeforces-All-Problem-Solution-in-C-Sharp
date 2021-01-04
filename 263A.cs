using System;
namespace TWo_dimenstional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,5];
            int row, col;
            int i = 2,j=2;
            int result=0;
            for (row = 0; row < 5; row++)
                
            {
                String []str = Console.ReadLine().Split(' ');
          
                for (col = 0; col < 5; col++)
                {
                    array[row, col] = Convert.ToInt32(str[col]);
                    if (array[row, col] == 1)
                    {
                        result = Math.Abs(i - row)+Math.Abs(j-col);
                        
                    }
                }
            }

            Console.WriteLine("" + result);

          
         

           
        }
    }
}





