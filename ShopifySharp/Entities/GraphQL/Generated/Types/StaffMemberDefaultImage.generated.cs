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
/// Represents the fallback avatar image for a staff member. This is used only if the staff member has no avatar image.
/// </summary>
public enum StaffMemberDefaultImage
{
    DEFAULT,
    TRANSPARENT,
    NOT_FOUND,
}