using System;

namespace ShopifySharp;

internal static class StringExtensions
{
    /// <summary>
    /// Checks if a string starts with another string, ignoring case.
    /// </summary>
    public static bool StartsWithIgnoreCase(this string str, string a) => str.StartsWith(a, StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Checks if a string ends with another string, ignoring case.
    /// </summary>
    public static bool EndsWithIgnoreCase(this string str, string a) => str.EndsWith(a, StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// Checks if a string contains another string, ignoring case.
    /// </summary>
    public static bool ContainsIgnoreCase(this string str, string a) => str.IndexOf(a, StringComparison.OrdinalIgnoreCase) >= 0;
}
