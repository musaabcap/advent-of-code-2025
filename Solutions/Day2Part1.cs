namespace AdventCode25.Solutions;

using AdventCode25.Reader;

public class Day2Part1
{
    public static async Task SolveDay2Part1()
    {
        var line = await FileReader.ReadLinesAsync(2,1);

        string endRange = line [0];

        string [] parts = endRange.Split(',');

        long totalInvalid = 0; 

        foreach(var part in parts)
        {
            string [] index = part.Split('-');

            long firstNumber = long.Parse(index[0]);
            long secondNumber = long.Parse(index[1]);

            for(long i=firstNumber; i<=secondNumber; i++)
            {
                if (IsInvalid(i))
                {
                    totalInvalid += i;
                }
            }
        }
        Console.WriteLine($"\nTotal count of invalid IDs: {totalInvalid}");
    }
    static bool IsInvalid(long number)
    {
        string numStr = number.ToString();

        if(numStr.Length%2 != 0)
        {
            return false;
        }

        int half = numStr.Length/2;
        string firstHalf = numStr.Substring(0,half);
        string secondHalf = numStr.Substring(half);

        return firstHalf == secondHalf;
    }
}