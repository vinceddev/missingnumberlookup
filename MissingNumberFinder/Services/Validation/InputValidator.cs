using MissingNumberFinder.Interfaces;

namespace MissingNumberFinder.Services.Validation;

public class InputValidator : IInputValidator
{
    public void Validate(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Input array cannot be null or empty.");
        }

        int n = nums.Length;

        foreach (int num in nums)
        {
            if (num < 0 || num > n)
            {
                throw new ArgumentException($"Number {num} is out of valid range [0, {n}].");
            }
        }

        var uniqueNumbers = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!uniqueNumbers.Add(num))
            {
                throw new ArgumentException($"Duplicate number found: {num}.");
            }
        }
    }
}
