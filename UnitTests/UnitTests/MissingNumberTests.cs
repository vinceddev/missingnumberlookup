using MissingNumberFinder.Interfaces;
using MissingNumberFinder.Services.Utils;

namespace UnitTests
{
    public class MissingNumberTests
    {
        private readonly IMissingNumberLookup _lookup;

        public MissingNumberTests()
        {
            _lookup = new MissingNumberLookup();
        }

        [Fact]
        public void FindThreeInputs_ShouldReturnCorrectResult()
        {
            int[] nums = { 3, 0, 1 };
            int result = _lookup.FindMissingNumber(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindNineInputs_ShouldReturnCorrectResult()
        {
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int result = _lookup.FindMissingNumber(nums);
            Assert.Equal(8, result);
        }
    }
}
