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

public class BulkOperationRunQueryPayloadQueryBuilder() : GraphQueryBuilder<BulkOperationRunQueryPayload>("bulkOperationRunQueryPayload")
{
    public BulkOperationRunQueryPayloadQueryBuilder AddFieldBulkOperation(Func<BulkOperationQueryBuilder, BulkOperationQueryBuilder> build)
    {
        AddField<BulkOperation, BulkOperationQueryBuilder>("bulkOperation", build);
        return this;
    }

    public BulkOperationRunQueryPayloadQueryBuilder AddFieldUserErrors(Func<BulkOperationUserErrorQueryBuilder, BulkOperationUserErrorQueryBuilder> build)
    {
        AddField<BulkOperationUserError, BulkOperationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}