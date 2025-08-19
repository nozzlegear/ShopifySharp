#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Digital wallet, such as Apple Pay, which can be used for accelerated checkouts.
/// </summary>
public enum DigitalWallet
{
    APPLE_PAY,
    ANDROID_PAY,
    GOOGLE_PAY,
    SHOPIFY_PAY,
    FACEBOOK_PAY,
    AMAZON_PAY,
}