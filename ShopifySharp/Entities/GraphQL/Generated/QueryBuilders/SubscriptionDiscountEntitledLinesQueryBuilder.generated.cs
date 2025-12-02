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

public class SubscriptionDiscountEntitledLinesQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountEntitledLines>("subscriptionDiscountEntitledLines")
{
    public SubscriptionDiscountEntitledLinesQueryBuilder AddFieldAll()
    {
        AddField("all");
        return this;
    }

    public SubscriptionDiscountEntitledLinesQueryBuilder AddFieldLines(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("lines", build);
        return this;
    }
}