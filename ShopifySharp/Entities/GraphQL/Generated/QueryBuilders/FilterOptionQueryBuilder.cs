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

public class FilterOptionQueryBuilder() : GraphQueryBuilder<FilterOption>("query filterOption")
{
    public FilterOptionQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }

    public FilterOptionQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}