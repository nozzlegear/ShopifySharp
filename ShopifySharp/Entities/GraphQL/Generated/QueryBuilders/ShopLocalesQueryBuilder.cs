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

public class ShopLocalesQueryBuilder() : GraphQueryBuilder<ShopLocale>("query shopLocales")
{
    public ShopLocalesQueryBuilder AddArgumentPublished(bool? published)
    {
        AddArgument("published", published);
        return this;
    }
}