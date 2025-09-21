#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible account types that a staff member can have.
/// </summary>
public enum AccountType
{
    REGULAR,
    RESTRICTED,
    INVITED,
    REQUESTED,
    COLLABORATOR,
    COLLABORATOR_TEAM_MEMBER,
    SAML,
    INVITED_STORE_OWNER,
}