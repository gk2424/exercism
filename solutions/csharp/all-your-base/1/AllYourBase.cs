public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        // 1. Input Validation
        if (inputBase < 2 || outputBase < 2 || inputDigits.Any(d => d < 0 || d >= inputBase))
        {
            throw new ArgumentException();
        }

        // 2. Convert to Base 10
        int decimalValue = 0;
        for (int i = 0; i < inputDigits.Length; i++)
        {
            decimalValue += inputDigits[i] * (int)Math.Pow(inputBase, inputDigits.Length - 1 - i);
        }

        // 3. Convert from Base 10 to Output Base
        List<int> outputDigits = new List<int>();
        if (decimalValue == 0)
        {
            outputDigits.Add(0);
        }
        else
        {
            while (decimalValue > 0)
            {
                outputDigits.Insert(0, decimalValue % outputBase);
                decimalValue /= outputBase;
            }
        }
        return outputDigits.ToArray();
    }
}