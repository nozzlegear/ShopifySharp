namespace ShopifySharp.GraphQL.Parser;

public enum CasingType
{
    /// <summary>
    /// Every word, including the first, starts with an uppercase letter.
    /// <example><c>MyVariableName</c>, <c>GetUserId</c></example>
    /// </summary>
    PascalCase,
    /// <summary>
    /// First word starts with a lowercase letter, and each subsequent word starts with an uppercase letter.
    /// <example><c>myVariableName</c>, <c>getUserId</c></example>
    /// </summary>
    CamelCase,
}