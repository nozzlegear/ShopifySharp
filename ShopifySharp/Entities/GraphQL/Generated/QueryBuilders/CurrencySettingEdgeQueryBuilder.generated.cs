#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CurrencySettingEdgeQueryBuilder() : GraphQueryBuilder<CurrencySettingEdge>("currencySettingEdge")
{
    public CurrencySettingEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CurrencySettingEdgeQueryBuilder AddFieldNode(Func<CurrencySettingQueryBuilder, CurrencySettingQueryBuilder> build)
    {
        AddField<CurrencySetting, CurrencySettingQueryBuilder>("node", build);
        return this;
    }
}