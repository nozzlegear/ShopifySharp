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

public class DeliveryConditionQueryBuilder() : GraphQueryBuilder<DeliveryCondition>("query deliveryCondition")
{
    public DeliveryConditionQueryBuilder AddFieldConditionCriteria()
    {
        AddField("conditionCriteria");
        return this;
    }

    public DeliveryConditionQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DeliveryConditionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryConditionQueryBuilder AddFieldOperator()
    {
        AddField("operator");
        return this;
    }
}