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

public class SegmentQueryBuilder() : GraphQueryBuilder<Segment>("query segment")
{
    public SegmentQueryBuilder AddFieldCreationDate()
    {
        AddField("creationDate");
        return this;
    }

    public SegmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SegmentQueryBuilder AddFieldLastEditDate()
    {
        AddField("lastEditDate");
        return this;
    }

    public SegmentQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SegmentQueryBuilder AddFieldQuery()
    {
        AddField("query");
        return this;
    }
}