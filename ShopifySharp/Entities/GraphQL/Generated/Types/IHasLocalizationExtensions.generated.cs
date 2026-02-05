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
/// Localization extensions associated with the specified resource. For example, the tax id for government invoice.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(Order), typeDiscriminator: "Order")]
public interface IHasLocalizationExtensions : IGraphQLObject
{
    /// <summary>
    /// List of localization extensions for the resource.
    /// </summary>
    [JsonPropertyName("localizationExtensions")]
    [Obsolete("This connection will be removed in a future version. Use `localizedFields` instead.")]
    public LocalizationExtensionConnection? localizationExtensions { get; set; }
}