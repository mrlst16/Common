using Common.Helpers;
using Common.Models.MockData;
using Xunit;

namespace Common.Tests.Helpers
{
    public class EnumHelperTests
    {

        [Fact]
        public async Task Iterate_AddInputsToList_TestCount()
        {
            List<(int, string, int)> results = new List<(int, string, int)>();

            EnumHelper.Iterate<MockNumberEnum>(((index, name, value) =>
            {
                results.Add((index, name, value));
            }));

            Assert.Equal(10, results.Count);
        }

        [Fact]
        public async Task Iterate_AddInputsToList_ValuesMatch_First3Only()
        {
            List<(int, string, int)> results = new List<(int, string, int)>();

            EnumHelper.Iterate<MockNumberEnum>(((index, name, value) =>
            {
                results.Add((index, name, value));
            }));

            var zero = results[0];
            var one = results[1];
            var two = results[2];

            Assert.Equal((0, "Zero", 0), zero);
            Assert.Equal((1, "One", 1), one);
            Assert.Equal((2, "Two", 2), two);
        }
    }
}
