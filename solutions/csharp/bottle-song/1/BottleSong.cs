using System.Collections.Generic;

public static class BottleSong
{
   static Dictionary<int, string> numbersToString = new Dictionary<int, string>()
    {
    { 0, "No"  },
    { 1, "One" },
    { 2, "Two" },
    { 3, "Three" },
    { 4, "Four" },
    { 5, "Five" },
    { 6, "Six" },
    { 7, "Seven" },
    { 8, "Eight" },
    { 9, "Nine" },
    {10, "Ten" }
    };
    public static string[] Recite(int startBottles, int takeDown)
    {
        List<string> verses = new List<string>();
        for (int i = 0; i < takeDown; i++)
        {
            if (startBottles == 1)
            {
                verses.Add($"{numbersToString[startBottles]} green bottle hanging on the wall,");
                verses.Add($"{numbersToString[startBottles]} green bottle hanging on the wall,");
                verses.Add($"And if one green bottle should accidentally fall,");
                startBottles = startBottles - 1;
            }
            else if (startBottles > 1)
            {
                verses.Add($"{numbersToString[startBottles]} green bottles hanging on the wall,");
                verses.Add($"{numbersToString[startBottles]} green bottles hanging on the wall,");
                verses.Add($"And if one green bottle should accidentally fall,");
                startBottles = startBottles - 1;
            }
            if (startBottles == 1 && i + 1 == takeDown)
            {
                verses.Add($"There'll be {numbersToString[startBottles].ToLower()} green bottle hanging on the wall.");
            }
            else if (startBottles == 1)
            {
                verses.Add($"There'll be {numbersToString[startBottles].ToLower()} green bottle hanging on the wall.");
                verses.Add("");
            }
            else if (i + 1 == takeDown)
            {
                verses.Add($"There'll be {numbersToString[startBottles].ToLower()} green bottles hanging on the wall.");
            }
            else
            {
                verses.Add($"There'll be {numbersToString[startBottles].ToLower()} green bottles hanging on the wall.");
                verses.Add("");
            }
        }
        string[] song = verses.ToArray();
        return song;
    }
}
