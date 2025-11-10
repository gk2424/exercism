public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();
        var bracketPairs = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        foreach (char c in input)
        {
            if (bracketPairs.ContainsKey(c)) // It's an opening bracket
            {
                stack.Push(c);
            }
            else if (bracketPairs.ContainsValue(c)) // It's a closing bracket
            {
                if (stack.Count == 0) // No opening bracket to match
                {
                    return false;
                }

                char lastOpenBracket = stack.Pop();
                if (bracketPairs[lastOpenBracket] != c) // Mismatch
                {
                    return false;
                }
            }
            // Ignore other characters
        }

        return stack.Count == 0; // All opening brackets should be closed
    }
}
