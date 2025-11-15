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

public class ISegmentFilterQueryBuilder() : GraphQueryBuilder<ISegmentFilter>("query iSegmentFilter")
{
    public ISegmentFilterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public ISegmentFilterQueryBuilder AddFieldMultiValue()
    {
        AddField("multiValue");
        return this;
    }

    public ISegmentFilterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }
}