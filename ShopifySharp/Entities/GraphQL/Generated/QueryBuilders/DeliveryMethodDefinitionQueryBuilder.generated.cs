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

public class DeliveryMethodDefinitionQueryBuilder() : GraphQueryBuilder<DeliveryMethodDefinition>("deliveryMethodDefinition")
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

    public DeliveryMethodDefinitionQueryBuilder AddFieldMethodConditions(Func<DeliveryConditionQueryBuilder, DeliveryConditionQueryBuilder> build)
    {
        AddField<DeliveryCondition, DeliveryConditionQueryBuilder>("methodConditions", build);
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddUnionCaseRateProvider(Func<DeliveryParticipantQueryBuilder, DeliveryParticipantQueryBuilder> build)
    {
        AddUnion<DeliveryParticipant, DeliveryParticipantQueryBuilder>("rateProvider", build);
        return this;
    }

    public DeliveryMethodDefinitionQueryBuilder AddUnionCaseRateProvider(Func<DeliveryRateDefinitionQueryBuilder, DeliveryRateDefinitionQueryBuilder> build)
    {
        AddUnion<DeliveryRateDefinition, DeliveryRateDefinitionQueryBuilder>("rateProvider", build);
        return this;
    }
}