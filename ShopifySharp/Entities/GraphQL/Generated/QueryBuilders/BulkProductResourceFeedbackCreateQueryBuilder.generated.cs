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

public class BulkProductResourceFeedbackCreateQueryBuilder() : GraphQueryBuilder<BulkProductResourceFeedbackCreatePayload>("bulkProductResourceFeedbackCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public BulkProductResourceFeedbackCreateQueryBuilder AddArgumentFeedbackInput(ICollection<ProductResourceFeedbackInput>? feedbackInput)
    {
        AddArgument("feedbackInput", feedbackInput);
        return this;
    }
}