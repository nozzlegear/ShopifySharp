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

public class BulkOperationRunMutationPayloadQueryBuilder() : GraphQueryBuilder<BulkOperationRunMutationPayload>("bulkOperationRunMutationPayload")
{
    public BulkOperationRunMutationPayloadQueryBuilder AddFieldBulkOperation(Func<BulkOperationQueryBuilder, BulkOperationQueryBuilder> build)
    {
        AddField<BulkOperation, BulkOperationQueryBuilder>("bulkOperation", build);
        return this;
    }

    public BulkOperationRunMutationPayloadQueryBuilder AddFieldUserErrors(Func<BulkMutationUserErrorQueryBuilder, BulkMutationUserErrorQueryBuilder> build)
    {
        AddField<BulkMutationUserError, BulkMutationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}