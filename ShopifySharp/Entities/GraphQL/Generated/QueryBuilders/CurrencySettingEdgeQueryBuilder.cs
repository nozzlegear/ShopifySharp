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

public class CurrencySettingEdgeQueryBuilder() : GraphQueryBuilder<CurrencySettingEdge>("query currencySettingEdge")
{
    public CurrencySettingEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CurrencySettingEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}