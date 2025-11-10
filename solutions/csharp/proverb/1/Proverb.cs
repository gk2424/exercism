public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        // Handle the empty input case
        if (subjects.Length == 0)
        {
            return Array.Empty<string>();
        }

        // Create a list to store the proverb lines
        List<string> proverbLines = new List<string>();

        // Generate the "For want of a..." lines
        for (int i = 0; i < subjects.Length - 1; i++)
        {
            proverbLines.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }

        // Add the final line
        proverbLines.Add($"And all for the want of a {subjects[0]}.");

        // Return the proverb as an array of strings
        return proverbLines.ToArray();
    }
}