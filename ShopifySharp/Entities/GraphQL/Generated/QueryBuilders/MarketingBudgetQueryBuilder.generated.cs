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

public class MarketingBudgetQueryBuilder() : GraphQueryBuilder<MarketingBudget>("marketingBudget")
{
    public MarketingBudgetQueryBuilder AddFieldBudgetType()
    {
        AddField("budgetType");
        return this;
    }

    public MarketingBudgetQueryBuilder AddFieldTotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("total", build);
        return this;
    }
}