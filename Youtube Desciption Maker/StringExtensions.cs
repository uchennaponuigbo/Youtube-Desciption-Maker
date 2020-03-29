namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (maxLength < 0)
                maxLength = 0;
            if (!string.IsNullOrEmpty(value) && value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }

            return value;
        }
    }
}
