public static class Hamming
{
   public static int Distance(string firstStrand, string secondStrand)
    {
        // The Hamming distance is only defined for sequences of equal length.
        // If the lengths are different, an ArgumentException should be thrown.
        if (firstStrand.Length != secondStrand.Length)
        {
            throw new ArgumentException("DNA strands must be of equal length.");
        }

        int distance = 0;
        // Iterate through the strings and count the differences.
        for (int i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
            {
                distance++;
            }
        }
        return distance;
    }
}