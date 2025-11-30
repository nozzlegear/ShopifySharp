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

public class LocalizationExtensionConnectionQueryBuilder() : GraphQueryBuilder<LocalizationExtensionConnection>("query localizationExtensionConnection")
{
    public LocalizationExtensionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public LocalizationExtensionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public LocalizationExtensionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}