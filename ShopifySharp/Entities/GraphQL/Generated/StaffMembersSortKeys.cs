#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the StaffMembers query.
/// </summary>
public enum StaffMembersSortKeys
{
    EMAIL,
    FIRST_NAME,
    ID,
    LAST_NAME,
}