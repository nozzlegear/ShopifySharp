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

public class DeliveryProfileItemQueryBuilder() : GraphQueryBuilder<DeliveryProfileItem>("query deliveryProfileItem")
{
    public DeliveryProfileItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryProfileItemQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public DeliveryProfileItemQueryBuilder AddFieldVariants()
    {
        AddField("variants");
        return this;
    }
}