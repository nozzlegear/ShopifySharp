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
/// A user account that can access the Shopify admin to manage store operations.
/// Includes personal information and account status.
/// You can assign staff members to [`CompanyLocation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/CompanyLocation)
/// objects for [B2B operations](https://shopify.dev/docs/apps/build/b2b), limiting
/// their actions to those locations.
/// </summary>
public record StaffMember : IGraphQLObject, INode
{
    /// <summary>
    /// The type of account the staff member has.
    /// </summary>
    [JsonPropertyName("accountType")]
    public AccountType? accountType { get; set; } = null;

    /// <summary>
    /// Whether the staff member is active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// The image used as the staff member's avatar in the Shopify admin.
    /// </summary>
    [JsonPropertyName("avatar")]
    public Image? avatar { get; set; } = null;

    /// <summary>
    /// The staff member's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// Whether the staff member's account exists.
    /// </summary>
    [JsonPropertyName("exists")]
    public bool? exists { get; set; } = null;

    /// <summary>
    /// The staff member's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The staff member's initials, if available.
    /// </summary>
    [JsonPropertyName("initials")]
    public ICollection<string>? initials { get; set; } = null;

    /// <summary>
    /// Whether the staff member is the shop owner.
    /// </summary>
    [JsonPropertyName("isShopOwner")]
    public bool? isShopOwner { get; set; } = null;

    /// <summary>
    /// The staff member's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The staff member's preferred locale. Locale values use the format `language`
    /// or `language-COUNTRY`, where `language` is a two-letter language code, and
    /// `COUNTRY` is a two-letter country code. For example: `en` or `en-US`
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The staff member's full name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The staff member's phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The data used to customize the Shopify admin experience for the staff member.
    /// </summary>
    [JsonPropertyName("privateData")]
    public StaffMemberPrivateData? privateData { get; set; } = null;
}