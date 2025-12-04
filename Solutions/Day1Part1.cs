using AdventCode25.Reader;

namespace AdventCode25.Solutions;

public class Day1Part1
{
    public static async Task SolveDay1()
    {
        var lines = await FileReader.ReadLinesAsync(1,1);

        int currentPosition = 50;
        int timesPointingAtZero = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            
            char direction = line[0];
            int steps = int.Parse(line[1..]);

            if (direction == 'R')
            {
                currentPosition += steps;
            }
            else if (direction == 'L')
            {
                currentPosition -= steps;
            }

            currentPosition = currentPosition % 100;
            if(currentPosition < 0) currentPosition += 100;

            if(currentPosition == 0)
            {
                timesPointingAtZero++;
            }
        }
        Console.WriteLine($"Password: {timesPointingAtZero}");
    }
}