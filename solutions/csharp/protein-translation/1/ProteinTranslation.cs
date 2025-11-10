public static class ProteinTranslation
{
    // Define the mapping from codons to proteins
    private static readonly Dictionary<string, string> codonToProtein = new Dictionary<string, string>
    {
        { "AUG", "Methionine" },
        { "UUU", "Phenylalanine" },
        { "UUC", "Phenylalanine" },
        { "UUA", "Leucine" },
        { "UUG", "Leucine" },
        { "UCU", "Serine" },
        { "UCC", "Serine" },
        { "UCA", "Serine" },
        { "UCG", "Serine" },
        { "UAU", "Tyrosine" },
        { "UAC", "Tyrosine" },
        { "UGU", "Cysteine" },
        { "UGC", "Cysteine" },
        { "UGG", "Tryptophan" },
        { "UAA", "STOP" },
        { "UAG", "STOP" },
        { "UGA", "STOP" }
    };

    public static string[] Proteins(string strand)
    {
        List<string> proteins = new List<string>();

        // Iterate through the RNA strand, taking 3 characters at a time (codons)
        for (int i = 0; i < strand.Length; i += 3)
        {
            // Ensure there are enough characters for a full codon
            if (i + 2 >= strand.Length)
            {
                // Optionally handle incomplete codons, e.g., throw an exception or ignore
                throw new ArgumentException("Invalid RNA strand length: must be a multiple of 3.");
            }

            string currentCodon = strand.Substring(i, 3);

            // Translate the codon to its corresponding protein
            if (codonToProtein.TryGetValue(currentCodon, out string protein))
            {
                if (protein == "STOP")
                {
                    break; // Stop translation if a STOP codon is found
                }
                proteins.Add(protein);
            }
            else
            {
                // Handle unknown codons, e.g., throw an exception
                throw new ArgumentException($"Unknown codon encountered: {currentCodon}");
            }
        }

        return proteins.ToArray();
    }
}