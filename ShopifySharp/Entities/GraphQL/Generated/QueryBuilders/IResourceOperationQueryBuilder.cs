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

public class IResourceOperationQueryBuilder() : GraphQueryBuilder<IResourceOperation>("query iResourceOperation")
{
    public IResourceOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IResourceOperationQueryBuilder AddFieldProcessedRowCount()
    {
        AddField("processedRowCount");
        return this;
    }

    public IResourceOperationQueryBuilder AddFieldRowCount()
    {
        AddField("rowCount");
        return this;
    }

    public IResourceOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}