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
/// A resource in Shopify that contains fields available for translation into
/// different languages. Accesses the resource's translatable content, existing [`Translation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Translation)
/// objects, and any nested resources that can also be translated.
/// The [`TranslatableContent`](https://shopify.dev/docs/api/admin-graphql/latest/objects/TranslatableContent) includes field keys, values, and digest hashes needed when [registering translations](https://shopify.dev/docs/api/admin-graphql/latest/mutations/translationsRegister).
/// You can retrieve translations for specific
/// [`Locale`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Locale) and
/// [`Market`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Market)
/// configurations. Each translation includes an `outdated` flag indicating whether
/// the original content has changed since that translation was last updated.
/// Learn more about [managing translated content](https://shopify.dev/docs/apps/build/markets/manage-translated-content).
/// </summary>
public record TranslatableResource : IGraphQLObject
{
    /// <summary>
    /// Nested translatable resources under the current resource.
    /// </summary>
    [JsonPropertyName("nestedTranslatableResources")]
    public TranslatableResourceConnection? nestedTranslatableResources { get; set; } = null;

    /// <summary>
    /// GID of the resource.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? resourceId { get; set; } = null;

    /// <summary>
    /// Translatable content.
    /// </summary>
    [JsonPropertyName("translatableContent")]
    public ICollection<TranslatableContent>? translatableContent { get; set; } = null;

    /// <summary>
    /// Translatable content translations (includes unpublished locales).
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}