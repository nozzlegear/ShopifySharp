#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the fallback avatar image for a staff member. This is used only if the staff member has no avatar image.
/// </summary>
public enum StaffMemberDefaultImage
{
    DEFAULT,
    TRANSPARENT,
    NOT_FOUND,
}