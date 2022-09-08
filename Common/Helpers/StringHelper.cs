using System.Text;

namespace Common.Helpers
{
    public static class StringHelper
    {
        public static string RandomAlphanumericString(int length)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int randNumber = rand.Next(48, 90);
                char c = (char)randNumber;
                builder.Append(c);
            }
            return builder.ToString();
        }
    }
}
