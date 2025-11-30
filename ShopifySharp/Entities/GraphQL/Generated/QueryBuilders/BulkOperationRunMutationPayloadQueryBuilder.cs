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

public class BulkOperationRunMutationPayloadQueryBuilder() : GraphQueryBuilder<BulkOperationRunMutationPayload>("query bulkOperationRunMutationPayload")
{
    public BulkOperationRunMutationPayloadQueryBuilder AddFieldBulkOperation()
    {
        AddField("bulkOperation");
        return this;
    }

    public BulkOperationRunMutationPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}