public static class ResistorColorDuo
{
    // A dictionary to map color names to their corresponding digit values
    private static readonly Dictionary<string, int> ColorValues = new Dictionary<string, int>
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

    public static int Value(string[] colors)
    {
        // Get the value of the first color band and multiply by 10
        int firstDigit = ColorValues[colors[0]] * 10;

        // Get the value of the second color band
        int secondDigit = ColorValues[colors[1]];

        // Return the combined two-digit value
        return firstDigit + secondDigit;
    }
}
