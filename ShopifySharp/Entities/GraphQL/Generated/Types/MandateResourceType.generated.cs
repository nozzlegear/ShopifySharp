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
/// The type of resource a payment mandate can be used for.
/// </summary>
public enum MandateResourceType
{
    CREDENTIAL_ON_FILE,
    CHECKOUT,
    DRAFT_ORDER,
    ORDER,
    SUBSCRIPTIONS,
}