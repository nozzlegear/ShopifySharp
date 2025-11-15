#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

[Obsolete("Use `productByIdentifier` instead.")]
public class ProductByHandleQueryBuilder() : GraphQueryBuilder<Product>("query productByHandle")
{
    public ProductByHandleQueryBuilder AddArgumentHandle(string? handle)
    {
        AddArgument("handle", handle);
        return this;
    }
}