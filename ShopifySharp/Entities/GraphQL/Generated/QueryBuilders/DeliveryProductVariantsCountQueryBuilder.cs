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

public class DeliveryProductVariantsCountQueryBuilder() : GraphQueryBuilder<DeliveryProductVariantsCount>("query deliveryProductVariantsCount")
{
    public DeliveryProductVariantsCountQueryBuilder AddFieldCapped()
    {
        AddField("capped");
        return this;
    }

    public DeliveryProductVariantsCountQueryBuilder AddFieldCount()
    {
        AddField("count");
        return this;
    }
}