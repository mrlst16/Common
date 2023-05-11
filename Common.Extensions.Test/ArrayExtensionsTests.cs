using Common.Extensions;

namespace Common.Extensions.Test
{
    public class ArrayExtensionsTests
    {
        #region Tests
        
        [Theory]
        [MemberData(nameof(SwitchTestData))]
        public void SwitchTheory(int p1, int p2, int[] expected)
        {
            int[] array = { 1, 2, 3, 4 };
            var result = array.Switch(p1, p2);
            
            Assert.Equal(result, expected);
        }

        [Theory]
        [MemberData(nameof(UniqueTestData))]
        public void IsUniqueTheory(int[] array, bool expected)
        {
            var result = array.IsUnique();
            Assert.Equal(expected, result);
        }

        #endregion


        #region Member Data

        private static IEnumerable<object[]> SwitchTestData() => new List<object[]>
        {
            new object[]{ 0, 1, new int[]{ 2, 1, 3, 4 } },
            new object[]{ 1, 2, new int[]{ 1, 3, 2, 4} },
            new object[]{ 2, 3, new int[] { 1, 2, 4, 3 } }
        };

        private static IEnumerable<object[]> UniqueTestData() => new List<object[]>
        {
            new object[]{ new int[] {1, 2, 3, 4, 5, 6, 7}, true },
            new object[]{ new int[] {1, 2, 3, 4, 5, 6, 7, 1}, false }
        };

        #endregion
    }
}