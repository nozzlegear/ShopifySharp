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

public class BulkOperationQueryBuilder() : GraphQueryBuilder<BulkOperation>("bulkOperation")
{
    public BulkOperationQueryBuilder AddFieldCompletedAt()
    {
        AddField("completedAt");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldFileSize()
    {
        AddField("fileSize");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldObjectCount()
    {
        AddField("objectCount");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldPartialDataUrl()
    {
        AddField("partialDataUrl");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldQuery()
    {
        AddField("query");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldRootObjectCount()
    {
        AddField("rootObjectCount");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public BulkOperationQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}