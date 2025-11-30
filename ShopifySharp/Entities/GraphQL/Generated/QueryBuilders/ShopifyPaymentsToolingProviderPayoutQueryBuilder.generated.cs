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

public class ShopifyPaymentsToolingProviderPayoutQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsToolingProviderPayout>("shopifyPaymentsToolingProviderPayout")
{
    public ShopifyPaymentsToolingProviderPayoutQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public ShopifyPaymentsToolingProviderPayoutQueryBuilder AddFieldArrivalDate()
    {
        AddField("arrivalDate");
        return this;
    }

    public ShopifyPaymentsToolingProviderPayoutQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ShopifyPaymentsToolingProviderPayoutQueryBuilder AddFieldCurrency()
    {
        AddField("currency");
        return this;
    }

    public ShopifyPaymentsToolingProviderPayoutQueryBuilder AddFieldRemoteId()
    {
        AddField("remoteId");
        return this;
    }
}