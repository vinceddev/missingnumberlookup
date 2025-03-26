using MissingNumberFinder.Interfaces;

namespace MissingNumberFinder.Services.Core;

public class MissingNumberApp
{
    private readonly IInputReader _inputReader;
    private readonly IInputParser _inputParser;
    private readonly IInputValidator _inputValidator;
    private readonly IMissingNumberLookup _missingNumberFinder;
    private readonly IOutputWriter _outputWriter;

    public MissingNumberApp(
        IInputReader inputReader,
        IInputParser inputParser,
        IInputValidator inputValidator,
        IMissingNumberLookup missingNumberFinder,
        IOutputWriter outputWriter)
    {
        _inputReader = inputReader;
        _inputParser = inputParser;
        _inputValidator = inputValidator;
        _missingNumberFinder = missingNumberFinder;
        _outputWriter = outputWriter;
    }

    public void Run()
    {
        while (true)
        {
            try
            {
                string input = _inputReader.ReadInput();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                int[] numbers = _inputParser.Parse(input);
                _inputValidator.Validate(numbers);

                int missingNumber = _missingNumberFinder.FindMissingNumber(numbers);
                _outputWriter.WriteOutput(missingNumber);
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
