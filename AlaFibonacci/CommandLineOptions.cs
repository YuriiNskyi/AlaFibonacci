using CommandLine;

namespace AlaFibonacci
{
    public class CommandLineOptions
    {
        [Option('i', "index", Required = true, HelpText = "Index of AlaFibonacci sequence. Must be a positive number.")]
        public uint Index { get; set; }
    }
}
