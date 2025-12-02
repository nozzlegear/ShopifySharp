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

public class CalculatedRestockingFeeQueryBuilder() : GraphQueryBuilder<CalculatedRestockingFee>("calculatedRestockingFee")
{
    public CalculatedRestockingFeeQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    public CalculatedRestockingFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedRestockingFeeQueryBuilder AddFieldPercentage()
    {
        AddField("percentage");
        return this;
    }
}