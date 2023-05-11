namespace Common.Extensions
{
    public static class ArrayExtensions
    {
        public static T[] Switch<T>(this T[] array, int p1, int p2)
        {
            var p1Val = array[p1];
            var p2Val = array[p2];
            array[p1] = p2Val;
            array[p2] = p1Val;
            return array;
        }

        public static bool IsUnique<T>(this T[] array) =>
            !array.GroupBy(k => k)
                .Select(x => x.Count())
                .Any(x => x > 1);

        public static T[] GetRow<T>(
            this T[,] array,
            int rowNumber
            )
        {
            int length = array.GetLength(1);
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = array[rowNumber, i];
            }
            return result;
        }

        public static T[] GetColumn<T>(
            this T[,] array,
            int columnNumber
            )
        {
            int length = array.GetLength(0);
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = array[i, columnNumber];
            }
            return result;
        }

        public static T[] ShiftForwardAround<T>(
            this T[] array,
            int positions = 1
            )
        {
            if (positions >= array.Length)
                throw new ArgumentOutOfRangeException(nameof(positions));

            if (positions == 0) return array;

            T[] result = new T[array.Length];
            int stoppingPoint = array.Length - positions;

            for (int i = 0; i < positions; i++)
                result[i] = array[stoppingPoint + i];

            for (int i = positions; i < array.Length; i++)
                result[i] = array[i - positions];

            return result;
        }

        /// <summary>
        /// Get the square indicated by x/y parameters
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="x1">Inclusive starting x coordinate from the top</param>
        /// <param name="x2">Inclusive ending x coordinate from the top</param>
        /// <param name="y1">Inclusive starting y coordinate from the left</param>
        /// <param name="y2">Inclusive ending y coordinate from the left</param>
        /// <returns>2D array representing the </returns>
        public static T[,] GetSquare<T>(
            this T[,] array,
            int x1,
            int x2,
            int y1,
            int y2
            )
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            if (
                x1 > x2
            ) throw new ArgumentOutOfRangeException(nameof(x1));

            if (
                y1 > x2
            ) throw new ArgumentOutOfRangeException(nameof(y1));

            if (
                x2 >= n
            ) throw new ArgumentOutOfRangeException(nameof(x2));

            if (
                y2 >= m
            ) throw new ArgumentOutOfRangeException(nameof(y2));


            T[,] result = new T[x2 - x1 + 1, y2 - y1 + 1];

            for (int i = x1; i <= x2; i++)
                for (int j = y1; j <= y2; j++)
                    result[i - x1, j - y1] = array[i, j];

            return result;
        }
    }
}
