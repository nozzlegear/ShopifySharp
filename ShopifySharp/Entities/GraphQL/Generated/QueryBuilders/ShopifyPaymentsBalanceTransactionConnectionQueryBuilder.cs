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

public class ShopifyPaymentsBalanceTransactionConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBalanceTransactionConnection>("query shopifyPaymentsBalanceTransactionConnection")
{
    public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}