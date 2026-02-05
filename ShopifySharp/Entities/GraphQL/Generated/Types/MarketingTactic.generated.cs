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
/// The available types of tactics for a marketing activity.
/// </summary>
public enum MarketingTactic
{
    ABANDONED_CART,
    AD,
    AFFILIATE,
    LINK,
    LOYALTY,
    MESSAGE,
    NEWSLETTER,
    NOTIFICATION,
    POST,
    RETARGETING,
    TRANSACTIONAL,
    STOREFRONT_APP,
    SEO,
}