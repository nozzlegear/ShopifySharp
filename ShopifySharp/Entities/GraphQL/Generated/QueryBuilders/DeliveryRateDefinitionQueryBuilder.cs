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

public class DeliveryRateDefinitionQueryBuilder() : GraphQueryBuilder<DeliveryRateDefinition>("query deliveryRateDefinition")
{
    public DeliveryRateDefinitionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryRateDefinitionQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }
}