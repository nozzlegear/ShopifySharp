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

public class StoreCreditAccountTransactionConnectionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountTransactionConnection>("query storeCreditAccountTransactionConnection")
{
    public StoreCreditAccountTransactionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public StoreCreditAccountTransactionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StoreCreditAccountTransactionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}