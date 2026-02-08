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
/// The input fields for adding products to the Combined Listing.
/// </summary>
public record ChildProductRelationInput : GraphQLInputObject<ChildProductRelationInput>
{
    /// <summary>
    /// The ID of the child product.
    /// </summary>
    [JsonPropertyName("childProductId")]
    public string? childProductId { get; set; } = null;

    /// <summary>
    /// The parent option values.
    /// </summary>
    [JsonPropertyName("selectedParentOptionValues")]
    public ICollection<SelectedVariantOptionInput>? selectedParentOptionValues { get; set; } = null;
}