using MissingNumberFinder.Interfaces;

namespace MissingNumberFinder.Services.Input;

public class CommaSeparatedParser : IInputParser
{
    public int[] Parse(string input)
    {
        try
        {
            return input.Split(',')
                .Select(s => int.Parse(s.Trim()))
                .ToArray();
        }
        catch (FormatException ex)
        {
            throw new ArgumentException("Invalid input format. Please enter numbers separated by commas.", ex);
        }
    }
}
