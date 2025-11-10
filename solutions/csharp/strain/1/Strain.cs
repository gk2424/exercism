public static class Strain
{
   // Keep method: Returns elements that satisfy the predicate
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (T item in collection)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }

    // Discard method: Returns elements that do NOT satisfy the predicate
    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (T item in collection)
        {
            if (!predicate(item))
            {
                yield return item;
            }
        }
    }
}