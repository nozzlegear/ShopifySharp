namespace ShopifySharp.GraphQL.Parser;

[Serializable]
public class TypeNameNotFoundException(string scalarName)
    : KeyNotFoundException($"Unable to find type name for scalar \"{scalarName}\".")
{
    public string ScalarName { get; } = scalarName;
}