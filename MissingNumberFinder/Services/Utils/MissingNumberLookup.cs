using MissingNumberFinder.Interfaces;

namespace MissingNumberFinder.Services.Utils;

public class MissingNumberLookup : IMissingNumberLookup
{
    /// <summary>
    /// Finds the missing number in the given array of numbers with gauss summation formula.
    /// The limitation is this method can only find one missing number.
    /// </summary>
    /// <param name="nums">Array of numbers</param>
    /// <returns>Single missing number.</returns>
    public int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expected = (n * (n + 1)) / 2;
        int actual = nums.Sum();
        return expected - actual;
    }
}
