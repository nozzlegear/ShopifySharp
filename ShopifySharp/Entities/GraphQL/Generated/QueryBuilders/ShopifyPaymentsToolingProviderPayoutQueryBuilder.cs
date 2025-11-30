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

public class ShopifyPaymentsToolingProviderPayoutQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsToolingProviderPayout>("query shopifyPaymentsToolingProviderPayout")
{
    public ShopifyPaymentsToolingProviderPayoutQueryBuilder AddFieldAmount()
    {
        AddField("amount");
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