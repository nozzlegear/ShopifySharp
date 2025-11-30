#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DeliveryConditionQueryBuilder() : GraphQueryBuilder<DeliveryCondition>("deliveryCondition")
{
    public DeliveryConditionQueryBuilder AddUnionCaseConditionCriteria(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("conditionCriteria", build);
        return this;
    }

    public DeliveryConditionQueryBuilder AddUnionCaseConditionCriteria(Func<WeightQueryBuilder, WeightQueryBuilder> build)
    {
        AddUnion<Weight, WeightQueryBuilder>("conditionCriteria", build);
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