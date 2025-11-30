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

public class DraftOrderShippingRateQueryBuilder() : GraphQueryBuilder<DraftOrderShippingRate>("draftOrderShippingRate")
{
    public DraftOrderShippingRateQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DraftOrderShippingRateQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public DraftOrderShippingRateQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public DraftOrderShippingRateQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public DraftOrderShippingRateQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}