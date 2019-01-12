using AlaFibonacci.Core;
using CommandLine;
using System;

namespace AlaFibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(option =>
                {
                    var calculated = AlaFibonacciCalculator.Calculate(option.Index);

                    Console.WriteLine($"Calculated value is: {calculated}");
                });
        }
    }
}
