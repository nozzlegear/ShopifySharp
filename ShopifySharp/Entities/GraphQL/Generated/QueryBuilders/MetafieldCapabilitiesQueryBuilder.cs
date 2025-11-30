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

public class MetafieldCapabilitiesQueryBuilder() : GraphQueryBuilder<MetafieldCapabilities>("query metafieldCapabilities")
{
    public MetafieldCapabilitiesQueryBuilder AddFieldAdminFilterable()
    {
        AddField("adminFilterable");
        return this;
    }

    public MetafieldCapabilitiesQueryBuilder AddFieldSmartCollectionCondition()
    {
        AddField("smartCollectionCondition");
        return this;
    }

    public MetafieldCapabilitiesQueryBuilder AddFieldUniqueValues()
    {
        AddField("uniqueValues");
        return this;
    }
}