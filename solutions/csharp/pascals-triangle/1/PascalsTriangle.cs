public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>> result = new List<List<int>>();
        if (rows == 0)
            return result;
        if (rows < 1)
            throw new ArgumentOutOfRangeException("At least 1 row");
        result.Add(new List<int> { 1 });
        for (int i = 1; i <= rows - 1; i++)
        {
            result.Add(new List<int> { 1 });
            for(int j = 1; j < i; j++)
            {
                result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
            }
            result[i].Add(1);
        }
        return result;
    }
}