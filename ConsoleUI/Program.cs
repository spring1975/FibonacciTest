using System;
using NumberUtils;

namespace ConsoleUI
{
    internal static class Program
    {
        private static void Main()
        {
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            var fCacluator = new FibonacciCalculator();
            Console.WriteLine($"Position 10 in the fibonacci sequence is {fCacluator.CalculateValueOfPosition(10)}.");
            Console.WriteLine($"Position 40 in the fibonacci sequence is {fCacluator.CalculateValueOfPosition(40)}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- Press any key to end the program -");
            Console.ReadLine();
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("An error occured.");
            Console.WriteLine("---------------------------");
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("- Press any key to end the program -");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
