public static class ResistorColorTrio
{
    private static readonly Dictionary<string, int> ColorCodes = new Dictionary<string, int>
    {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };

    public static string Label(string[] colors)
    {
        // Calculate the base value from the first two bands
        long baseValue = (long)ColorCodes[colors[0]] * 10 + ColorCodes[colors[1]];

        // Calculate the multiplier from the third band
        int multiplier = ColorCodes[colors[2]];

        // Calculate the total resistance in ohms
        long totalOhms = baseValue * (long)Math.Pow(10, multiplier);

        // Determine the appropriate unit and format the output
        if (totalOhms >= 1_000_000_000)
        {
            return $"{totalOhms / 1_000_000_000} gigaohms";
        }
        else if (totalOhms >= 1_000_000)
        {
            return $"{totalOhms / 1_000_000} megaohms";
        }
        else if (totalOhms >= 1_000)
        {
            return $"{totalOhms / 1_000} kiloohms";
        }
        else
        {
            return $"{totalOhms} ohms";
        }
    }
}
