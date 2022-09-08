namespace Common.Helpers
{
    public class EnumHelper
    {

        /// <summary>
        /// Iterates through the key value pairs, passing the index, name and int value of the enum
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <param name="action">
        /// The action.  Parameters are index(int), name(string), value(int)
        /// </param>
        public static void Iterate<E>(Action<int, string, int> action)
        where E : Enum
        {
            int i = 0;
            foreach (var value in Enum.GetValues(typeof(E)))
            {
                action(i, value?.ToString() ?? string.Empty, (int)(value ?? -1));
                i++;
            }
        }
    }
}
