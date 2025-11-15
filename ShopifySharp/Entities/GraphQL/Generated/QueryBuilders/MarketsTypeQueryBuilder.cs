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

public class MarketsTypeQueryBuilder() : GraphQueryBuilder<MarketsType>("query marketsType")
{
    public MarketsTypeQueryBuilder AddFieldB2b()
    {
        AddField("b2b");
        return this;
    }

    public MarketsTypeQueryBuilder AddFieldRegions()
    {
        AddField("regions");
        return this;
    }

    public MarketsTypeQueryBuilder AddFieldRetail()
    {
        AddField("retail");
        return this;
    }

    public MarketsTypeQueryBuilder AddFieldThemes()
    {
        AddField("themes");
        return this;
    }
}