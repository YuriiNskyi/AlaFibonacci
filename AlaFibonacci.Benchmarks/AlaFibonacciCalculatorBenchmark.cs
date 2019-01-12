using AlaFibonacci.Core;
using BenchmarkDotNet.Attributes;
using System.Numerics;

namespace AlaFibonacci.Benchmarks
{
    public class AlaFibonacciCalculatorBenchmark
    {
        [Params(0, 1, 5, 10, 25, 50, 100, 250, 500, 1000, 2500, 5000, 10000, 25000, 50000, 100000)]
        public uint Index { get; set; }


        [Benchmark]
        public BigInteger Calculate() => AlaFibonacciCalculator.Calculate(Index);
    }
}
