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

public class CalculatedShippingLineQueryBuilder() : GraphQueryBuilder<CalculatedShippingLine>("calculatedShippingLine")
{
    public CalculatedShippingLineQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedShippingLineQueryBuilder AddFieldPrice(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("price", build);
        return this;
    }

    public CalculatedShippingLineQueryBuilder AddFieldStagedStatus()
    {
        AddField("stagedStatus");
        return this;
    }

    public CalculatedShippingLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}