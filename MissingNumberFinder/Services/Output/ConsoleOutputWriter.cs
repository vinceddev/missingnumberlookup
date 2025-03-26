using MissingNumberFinder.Interfaces;

namespace MissingNumberFinder.Services.Output;

public class ConsoleOutputWriter : IOutputWriter
{
    public void WriteOutput(int result)
    {
        Console.WriteLine($"The missing number is: {result}");
    }
}
