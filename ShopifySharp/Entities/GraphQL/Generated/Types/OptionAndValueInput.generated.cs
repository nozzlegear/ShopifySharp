#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the options and values of the combined listing.
/// </summary>
public record OptionAndValueInput : GraphQLInputObject<OptionAndValueInput>
{
    /// <summary>
    /// The linked metafield for the product's option.
    /// </summary>
    [JsonPropertyName("linkedMetafield")]
    public LinkedMetafieldInput? linkedMetafield { get; set; } = null;

    /// <summary>
    /// The name of the Product's Option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The ID of the option to update. If not present, the option will be created.
    /// </summary>
    [JsonPropertyName("optionId")]
    public string? optionId { get; set; } = null;

    /// <summary>
    /// The ordered values of the Product's Option.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}