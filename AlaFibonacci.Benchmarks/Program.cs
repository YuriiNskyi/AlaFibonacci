using BenchmarkDotNet.Running;

namespace AlaFibonacci.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AlaFibonacciCalculatorBenchmark>();
        }
    }
}
