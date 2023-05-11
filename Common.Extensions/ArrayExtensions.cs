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

        public static T[] GetRow<T>(this T[,] array, int rowNumber)
        {
            int length = array.GetLength(1);
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = array[rowNumber, i];
            }
            return result;
        }

        public static T[] GetColumn<T>(this T[,] array, int columnNumber)
        {
            int length = array.GetLength(0);
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = array[i, columnNumber];
            }
            return result;
        }
    }
}
