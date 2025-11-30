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

public class MetafieldCapabilitiesQueryBuilder() : GraphQueryBuilder<MetafieldCapabilities>("metafieldCapabilities")
{
    public MetafieldCapabilitiesQueryBuilder AddFieldAdminFilterable(Func<MetafieldCapabilityAdminFilterableQueryBuilder, MetafieldCapabilityAdminFilterableQueryBuilder> build)
    {
        AddField<MetafieldCapabilityAdminFilterable, MetafieldCapabilityAdminFilterableQueryBuilder>("adminFilterable", build);
        return this;
    }

    public MetafieldCapabilitiesQueryBuilder AddFieldSmartCollectionCondition(Func<MetafieldCapabilitySmartCollectionConditionQueryBuilder, MetafieldCapabilitySmartCollectionConditionQueryBuilder> build)
    {
        AddField<MetafieldCapabilitySmartCollectionCondition, MetafieldCapabilitySmartCollectionConditionQueryBuilder>("smartCollectionCondition", build);
        return this;
    }

    public MetafieldCapabilitiesQueryBuilder AddFieldUniqueValues(Func<MetafieldCapabilityUniqueValuesQueryBuilder, MetafieldCapabilityUniqueValuesQueryBuilder> build)
    {
        AddField<MetafieldCapabilityUniqueValues, MetafieldCapabilityUniqueValuesQueryBuilder>("uniqueValues", build);
        return this;
    }
}