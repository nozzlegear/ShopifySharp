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

public class BulkOperationRunQueryPayloadQueryBuilder() : GraphQueryBuilder<BulkOperationRunQueryPayload>("query bulkOperationRunQueryPayload")
{
    public BulkOperationRunQueryPayloadQueryBuilder AddFieldBulkOperation()
    {
        AddField("bulkOperation");
        return this;
    }

    public BulkOperationRunQueryPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}