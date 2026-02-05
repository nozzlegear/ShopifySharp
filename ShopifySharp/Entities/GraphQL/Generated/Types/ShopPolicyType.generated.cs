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
/// Available shop policy types.
/// </summary>
public enum ShopPolicyType
{
    REFUND_POLICY,
    SHIPPING_POLICY,
    PRIVACY_POLICY,
    TERMS_OF_SERVICE,
    TERMS_OF_SALE,
    LEGAL_NOTICE,
    SUBSCRIPTION_POLICY,
    CONTACT_INFORMATION,
}