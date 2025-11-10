public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2)
        {
            return Array.Empty<int>();
        }

        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true; // Assume all numbers are prime initially
        }

        for (int p = 2; p * p <= limit; p++)
        {
            // If isPrime[p] is true, then it is a prime
            if (isPrime[p])
            {
                // Mark all multiples of p as not prime
                for (int i = p * p; i <= limit; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        List<int> primesList = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                primesList.Add(i);
            }
        }

        return primesList.ToArray();
    }
}