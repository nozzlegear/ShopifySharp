namespace ShopifySharp.GraphQL.QueryBuilders;

/// <summary>
/// Marker interface for QueryBuilders that have an Arguments property.
/// This interface provides type safety and enables generic constraints for helper methods.
/// </summary>
/// <typeparam name="TArgumentsBuilder">The type of the ArgumentsBuilder</typeparam>
public interface IHasArguments<out TArgumentsBuilder>
{
    /// <summary>
    /// Gets the ArgumentsBuilder for configuring query arguments.
    /// </summary>
    TArgumentsBuilder Arguments { get; }
}
