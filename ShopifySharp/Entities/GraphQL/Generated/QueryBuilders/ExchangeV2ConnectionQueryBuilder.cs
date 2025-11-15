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

public class ExchangeV2ConnectionQueryBuilder() : GraphQueryBuilder<ExchangeV2Connection>("query exchangeV2Connection")
{
    public ExchangeV2ConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ExchangeV2ConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ExchangeV2ConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}