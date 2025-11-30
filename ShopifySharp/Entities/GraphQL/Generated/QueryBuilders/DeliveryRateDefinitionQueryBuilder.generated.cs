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

public class DeliveryRateDefinitionQueryBuilder() : GraphQueryBuilder<DeliveryRateDefinition>("deliveryRateDefinition")
{
    public DeliveryRateDefinitionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryRateDefinitionQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }
}