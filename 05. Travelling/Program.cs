using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            //string input = Console.ReadLine();            
            string destination;
            double budget;

            input = Console.ReadLine();

            while (input != "End")
            {
                destination = input;
                budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < budget)
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentMoney;
                }

                Console.WriteLine($"Going to {destination}!");

                input = Console.ReadLine();

            }

        }
    }
}
