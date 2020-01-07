namespace ShopifySharp
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Checks if a string starts with another string, ignoring case.
        /// </summary>
        public static bool StartsWithIgnoreCase(this string str, string a) => str.ToLower().StartsWith(a.ToLower());

        /// <summary>
        /// Checks if a string ends with another string, ignoring case.
        /// </summary>
        public static bool EndsWithIgnoreCase(this string str, string a) => str.ToLower().EndsWith(a.ToLower());

        /// <summary>
        /// Checks if a string contains another string, ignorning case.
        /// </summary>
        public static bool ContainsIgnoreCase(this string str, string a) => str.ToLower().Contains(a.ToLower());
    }
}