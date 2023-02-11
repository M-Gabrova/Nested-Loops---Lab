using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            for (int a = x; a > 0; a--)
            {
                string buff = "";
                for (int b = 0; b < y; b++)
                {
                    if (a == x)
                    {
                        buff += "L" + a + b + " ";
                    }
                    else if (a % 2 == 0)
                    {
                        buff += "O" + a + b + " ";
                    }
                    else
                    {
                        buff += "A" + a + b + " ";
                    }

                }
                Console.WriteLine(buff);

            }
        }
    }
}
