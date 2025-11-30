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

public class CurrencySettingConnectionQueryBuilder() : GraphQueryBuilder<CurrencySettingConnection>("query currencySettingConnection")
{
    public CurrencySettingConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CurrencySettingConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CurrencySettingConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}