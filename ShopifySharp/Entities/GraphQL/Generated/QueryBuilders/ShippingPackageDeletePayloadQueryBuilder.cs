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

public class ShippingPackageDeletePayloadQueryBuilder() : GraphQueryBuilder<ShippingPackageDeletePayload>("query shippingPackageDeletePayload")
{
    public ShippingPackageDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public ShippingPackageDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}