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

public class DeliveryMethodDefinitionQueryBuilder() : GraphQueryBuilder<DeliveryMethodDefinition>("query deliveryMethodDefinition")
{
    public DeliveryMethodDefinitionQueryBuilder AddFieldActive()
    {
        AddField("active");
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddFieldMethodConditions()
    {
        AddField("methodConditions");
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddFieldRateProvider()
    {
        AddField("rateProvider");
        return this;
    }
}