public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Input must be a positive integer.");
        }

        int numberOfSteps = 0;
        long currentNumber = number; // Use long to prevent overflow for intermediate calculations

        while (currentNumber != 1)
        {
            if (currentNumber % 2 == 0)
            {
                currentNumber /= 2;
            }
            else
            {
                currentNumber = (currentNumber * 3) + 1;
            }
            numberOfSteps++;
        }
        return numberOfSteps;
    }
}