using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 10; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    int product = x * y;
                    Console.WriteLine($"{x} * {y} = {product}"); 
                }
            }
        }
    }
}
