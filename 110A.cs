using System;
public class Program
{
    public static void Main(String[]args)
    {
        int i, count = 0;
        String N;
        N = Console.ReadLine();
        for (i = 0; i < N.Length; i++)
        {
            if(N.Substring(i,1).Equals("7") || N.Substring(i, 1).Equals("4"))
            {
                count++;
            }
        }
        if(count==4 || count == 7)
        {
            Console.Write("YES\n");
        }
        else
        {
            Console.Write("NO\n");
        }
      
    }
}
