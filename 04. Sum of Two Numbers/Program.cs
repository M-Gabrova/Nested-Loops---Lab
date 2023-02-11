using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool flag = false;


            for (int x = start; x <= stop; x++)
            {
                for (int y = start; y <= stop; y++)
                {
                    combinationCounter++;
                    int result = x + y;
                    if (result == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({x} + {y} = {magicNumber})");
                        flag = true;
                        break;
                    }                
                }
            
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
               Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");

            }

        }
    }
}
