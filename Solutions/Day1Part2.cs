using AdventCode25.Reader;

namespace AdventCode25.Solutions;

public class Day1Part2
{
    public static async Task SolveDay1Part2()
    {
        var lines = await FileReader.ReadLinesAsync(1,1);

        int currentPosition = 50;
        int timesPassingZero = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            char direction = line[0];
            int steps = int.Parse(line[1..]);
            
            if (direction == 'R')
            {
                int startPosition = currentPosition;
                currentPosition += steps;
                int endPosition = currentPosition % 100;
                int crossings = steps / 100;  
    
                timesPassingZero += crossings;
    
                if (endPosition < startPosition && startPosition != 0)
                {
                    timesPassingZero++;
                }
                else if (endPosition == 0 && startPosition != 0)
                {
                    timesPassingZero++;
                }
    
                currentPosition = endPosition;
            }
            else if(direction == 'L')
            {
                int startPosition = currentPosition;
                currentPosition -= steps;
                int endPosition = currentPosition % 100;
                if(endPosition < 0) endPosition += 100;
                int crossings = steps / 100;  

                timesPassingZero += crossings;

                if (endPosition > startPosition && startPosition != 0)
                {
                    timesPassingZero++;
                }
                else if (endPosition == 0 && startPosition != 0)
                {
                    timesPassingZero++;
                }

                currentPosition = endPosition;
            }
        }
        Console.WriteLine($"Password: {timesPassingZero}");
    }
}