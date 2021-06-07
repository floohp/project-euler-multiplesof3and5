using System;

namespace project_euler_multiplesof3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    total = total + i;
                    Console.WriteLine(total);
                }
            }
            Console.ReadLine();
        }
    }
}
