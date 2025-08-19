#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the data used to customize the Shopify admin experience for a logged-in staff member.
/// </summary>
public record StaffMemberPrivateData : IGraphQLObject
{
    /// <summary>
    /// The URL to the staff member's account settings page.
    /// </summary>
    [JsonPropertyName("accountSettingsUrl")]
    public string? accountSettingsUrl { get; set; } = null;

    /// <summary>
    /// The date and time when the staff member was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Access permissions for the staff member.
    /// </summary>
    [JsonPropertyName("permissions")]
    [Obsolete("Theres no alternative field to use instead.")]
    public ICollection<StaffMemberPermission>? permissions { get; set; } = null;
}