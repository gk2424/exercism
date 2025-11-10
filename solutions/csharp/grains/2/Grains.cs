using System;
using System.Numerics;

public static class Grains
{
    public static BigInteger Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException(nameof(n), "Square number must be between 1 and 64");

        return BigInteger.Pow(2, n - 1);
    }

    // Метод Total в формате "expression-bodied"
    public static BigInteger Total() => BigInteger.Pow(2, 64) - 1;
}