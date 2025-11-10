public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        // Iterate over possible values for 'a'
        // 'a' must be less than sum / 3 to ensure 'b' and 'c' can be positive and distinct.
        for (int a = 1; a < sum / 3; a++)
        {
            // Iterate over possible values for 'b'
            // 'b' must be greater than 'a' and less than sum / 2.
            // This ensures a < b and leaves enough room for 'c' to be greater than 'b'.
            for (int b = a + 1; b < sum / 2; b++)
            {
                int c = sum - a - b;

                // Check if the triplet (a, b, c) satisfies the Pythagorean theorem
                // and the condition b < c.
                if (b < c && a * a + b * b == c * c)
                {
                    yield return (a, b, c);
                }
            }
        }
    }
}