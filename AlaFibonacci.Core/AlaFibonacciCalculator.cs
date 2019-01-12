using System.Numerics;

namespace AlaFibonacci.Core
{
    public static class AlaFibonacciCalculator
    {
        public static BigInteger Calculate(uint index)
        {
            if (index == 0 || index == 1)
            {
                return 1;
            }

            if (index == 2)
            {
                return 2;
            }

            BigInteger a = 1;
            BigInteger b = 1;
            BigInteger c = 2;

            for (uint i = 2; i < index; i++)
            {
                var tempC = c;
                c = a + b + c;
                a = b;
                b = tempC;
            }

            return c;
        }
    }
}
