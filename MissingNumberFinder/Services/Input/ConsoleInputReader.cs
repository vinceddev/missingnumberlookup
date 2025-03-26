using MissingNumberFinder.Interfaces;

namespace MissingNumberFinder.Services.Input;

public class ConsoleInputReader : IInputReader
{
    public string ReadInput()
    {
        Console.WriteLine("Enter numbers separated by commas (e.g., '3,0,1') or 'exit' to quit:");
        return Console.ReadLine();
    }
}
