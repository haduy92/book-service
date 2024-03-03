namespace BookStore.Common.Extensions
{
    /// <summary>
    /// Extension methods for strings.
    /// </summary>
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string? s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNullOrEmpty(this string? s)
        {
            return string.IsNullOrEmpty(s);
        }
    }
}