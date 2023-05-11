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

    }
}
