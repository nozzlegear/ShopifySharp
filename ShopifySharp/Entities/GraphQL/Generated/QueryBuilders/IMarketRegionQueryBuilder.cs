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

public class IMarketRegionQueryBuilder() : GraphQueryBuilder<IMarketRegion>("query iMarketRegion")
{
    public IMarketRegionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IMarketRegionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}