public class Robot
{
    private static readonly Random random = new Random();
    private static readonly HashSet<string> UsedNames = new HashSet<string>();

    public string Name { get; private set; }

    public Robot()
    {
        SetRandomName();
    }

    public void Reset()
    {
        UsedNames.Remove(Name);
        SetRandomName();
    }

    private void SetRandomName()
    {
        string newName;
        do
        {
            newName = GenerateRandomName();
        } while (UsedNames.Contains(newName));

        Name = newName;
        UsedNames.Add(Name);
    }

    private string GenerateRandomName()
    {
        string name = "";
        name += (char)('A' + random.Next(0, 26)); // First letter
        name += (char)('A' + random.Next(0, 26)); // Second letter
        name += random.Next(0, 10).ToString();    // First digit
        name += random.Next(0, 10).ToString();    // Second digit
        name += random.Next(0, 10).ToString();    // Third digit
        return name;
    }
}