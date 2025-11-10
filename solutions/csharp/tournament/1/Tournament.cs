public static class Tournament
{   
   public static void Tally(Stream inStream, Stream outStream)
    {
        var parsedInput = new List<string[]>();
        using (StreamReader reader = new StreamReader(inStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                parsedInput.Add(line.Split(";"));
            }
        }
        Dictionary<string, int[]> aggregatedResults = new Dictionary<string, int[]>();
        foreach (string[] line in parsedInput)
        {
            for (int i = 0; i
                < 2; i++)
            {
                aggregatedResults[line[i]] = new int[3];
            }
        }
        foreach (string[] line in parsedInput)
        {
            switch (line[2])
            {
                case "win":
                    aggregatedResults[line[0]][0]++;
                    aggregatedResults[line[1]][2]++;
                    break;
                case "draw":
                    aggregatedResults[line[0]][1]++;
                    aggregatedResults[line[1]][1]++;
                    break;
                case "loss":
                    aggregatedResults[line[0]][2]++;
                    aggregatedResults[line[1]][0]++;
                    break;
            }
        }
        var computedTable = new List<(string name, int[] results)>();
        foreach (var team in aggregatedResults)
        {
            var calculatedRow = new int[5];
            calculatedRow[0] = team.Value.Sum();
            calculatedRow[1] = team.Value[0];
            calculatedRow[2] = team.Value[1];
            calculatedRow[3] = team.Value[2];
            calculatedRow[4] = 3 * team.Value[0] + team.Value[1];
            computedTable.Add((team.Key, calculatedRow));
        }
        var sortedTable = computedTable.OrderByDescending(o => o.results[4])
                                       .ThenBy(o => o.name)
                                       .ToList();
        string output = $"{"Team",-30} | MP |  W |  D |  L |  P";
        foreach (var team in sortedTable)
        {
            output += $"\n{team.name,-30}";
            for (int i = 0; i < 5; i++)
            {
                output += $" | {team.results[i],2}";
            }
        }
        using (StreamWriter writer = new StreamWriter(outStream))
        {
            writer.Write(output);
        }
    }
}
