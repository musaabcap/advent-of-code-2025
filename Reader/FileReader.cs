namespace AdventCode25.Reader;

public class FileReader
{
    public static async Task<string[]> ReadLinesAsync(int day, int part)
    {
        return await File.ReadAllLinesAsync($"inputs/day{day}part{part}.txt");
    }
}