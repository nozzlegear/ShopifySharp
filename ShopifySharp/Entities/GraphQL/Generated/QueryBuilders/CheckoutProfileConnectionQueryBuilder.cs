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

public class CheckoutProfileConnectionQueryBuilder() : GraphQueryBuilder<CheckoutProfileConnection>("query checkoutProfileConnection")
{
    public CheckoutProfileConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CheckoutProfileConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CheckoutProfileConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}