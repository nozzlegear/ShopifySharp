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

public class ShopifyPaymentsBankAccountConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBankAccountConnection>("query shopifyPaymentsBankAccountConnection")
{
    public ShopifyPaymentsBankAccountConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ShopifyPaymentsBankAccountConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ShopifyPaymentsBankAccountConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}