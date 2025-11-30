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

public class IHasLocalizationExtensionsQueryBuilder() : GraphQueryBuilder<IHasLocalizationExtensions>("query iHasLocalizationExtensions")
{
    [Obsolete("This connection will be removed in a future version. Use `localizedFields` instead.")]
    public IHasLocalizationExtensionsQueryBuilder AddFieldLocalizationExtensions()
    {
        AddField("localizationExtensions");
        return this;
    }
}