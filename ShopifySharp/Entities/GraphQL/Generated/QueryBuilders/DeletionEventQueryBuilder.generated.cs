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

public class DeletionEventQueryBuilder() : GraphQueryBuilder<DeletionEvent>("deletionEvent")
{
    public DeletionEventQueryBuilder AddFieldOccurredAt()
    {
        AddField("occurredAt");
        return this;
    }

    public DeletionEventQueryBuilder AddFieldSubjectId()
    {
        AddField("subjectId");
        return this;
    }

    public DeletionEventQueryBuilder AddFieldSubjectType()
    {
        AddField("subjectType");
        return this;
    }
}