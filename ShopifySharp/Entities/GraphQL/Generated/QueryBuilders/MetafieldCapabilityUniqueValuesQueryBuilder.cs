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

public class MetafieldCapabilityUniqueValuesQueryBuilder() : GraphQueryBuilder<MetafieldCapabilityUniqueValues>("query metafieldCapabilityUniqueValues")
{
    public MetafieldCapabilityUniqueValuesQueryBuilder AddFieldEligible()
    {
        AddField("eligible");
        return this;
    }

    public MetafieldCapabilityUniqueValuesQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}