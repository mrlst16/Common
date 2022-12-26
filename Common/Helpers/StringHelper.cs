using System.Security.Cryptography;
using System.Text;

namespace Common.Helpers
{
    public static class StringHelper
    {
        private static string AlphanumericCharacters = "abcdefghijklmnopqrstuvwxyz1234567890";

        public static string RandomAlphanumericString(int length)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int randNumber = RandomNumberGenerator.GetInt32(0, 36);
                builder.Append(AlphanumericCharacters[randNumber]);
            }
            return builder.ToString();
        }
    }
}
