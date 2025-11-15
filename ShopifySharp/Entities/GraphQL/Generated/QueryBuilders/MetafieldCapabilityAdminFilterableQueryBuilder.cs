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

public class MetafieldCapabilityAdminFilterableQueryBuilder() : GraphQueryBuilder<MetafieldCapabilityAdminFilterable>("query metafieldCapabilityAdminFilterable")
{
    public MetafieldCapabilityAdminFilterableQueryBuilder AddFieldEligible()
    {
        AddField("eligible");
        return this;
    }

    public MetafieldCapabilityAdminFilterableQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }

    public MetafieldCapabilityAdminFilterableQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}