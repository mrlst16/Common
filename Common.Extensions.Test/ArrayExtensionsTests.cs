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

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(IsUniqueTestData))]
        public void IsUniqueTheory(int[] array, bool expected)
        {
            var result = array.IsUnique();
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetRowTestData))]
        public void GetRowTheory(int row, int[] expected)
        {
            int[,] array = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };
            var result = array.GetRow(row);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(GetColumnTestData))]
        public void GetColumnTheory(int column, int[] expected)
        {
            int[,] array = new int[,] {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };
            var result = array.GetColumn(column);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ShiftForwardAroundTestData))]
        public void ShiftForwardAroundTheory(int positions, int[] expected)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var result = array.ShiftForwardAround(positions);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShiftForwardAroundThrowsArgmentOutOfRangeException_PositionsEqualToLength()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Throws<ArgumentOutOfRangeException>(() => array.ShiftForwardAround(7));
        }

        [Fact]
        public void ShiftForwardAroundThrowsArgmentOutOfRangeException_PositionsGreaerThanLength()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Throws<ArgumentOutOfRangeException>(() => array.ShiftForwardAround(8));
        }

        #endregion


        #region Member Data

        private static IEnumerable<object[]> SwitchTestData() => new List<object[]>
        {
            new object[]{ 0, 1, new int[]{ 2, 1, 3, 4 } },
            new object[]{ 1, 2, new int[]{ 1, 3, 2, 4} },
            new object[]{ 2, 3, new int[] { 1, 2, 4, 3 } }
        };

        private static IEnumerable<object[]> IsUniqueTestData() => new List<object[]>
        {
            new object[]{ new int[] {1, 2, 3, 4, 5, 6, 7}, true },
            new object[]{ new int[] {1, 2, 3, 4, 5, 6, 7, 1}, false }
        };

        private static IEnumerable<object[]> GetRowTestData() => new List<object[]>
        {
            new object[]{ 0, new int[]{ 1, 2} },
            new object[]{ 1, new int[]{ 3, 4} },
            new object[]{ 2, new int[]{ 5, 6} }
        };

        private static IEnumerable<object[]> GetColumnTestData() => new List<object[]>
        {
            new object[]{ 0, new int[]{ 1, 3, 5} },
            new object[]{ 1, new int[]{ 2, 4, 6} }
        };

        private static IEnumerable<object[]> ShiftForwardAroundTestData() => new List<object[]>
        {
            new object[]{ 0, new int[] { 1, 2, 3, 4, 5, 6, 7 } },
            new object[]{ 1, new int[] { 7, 1, 2, 3, 4, 5, 6 } },
            new object[]{ 2, new int[] { 6, 7, 1, 2, 3, 4, 5 } },
            new object[]{ 3, new int[] { 5, 6, 7, 1, 2, 3, 4 } },
            new object[]{ 4, new int[] { 4, 5, 6, 7, 1, 2, 3 } },
            new object[]{ 5, new int[] { 3, 4, 5, 6, 7, 1, 2 } },
            new object[]{ 6, new int[] { 2, 3, 4, 5, 6, 7, 1 } }
        };

        #endregion
    }
}