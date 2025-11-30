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

public class BulkProductResourceFeedbackCreatePayloadQueryBuilder() : GraphQueryBuilder<BulkProductResourceFeedbackCreatePayload>("bulkProductResourceFeedbackCreatePayload")
{
    public BulkProductResourceFeedbackCreatePayloadQueryBuilder AddFieldFeedback(Func<ProductResourceFeedbackQueryBuilder, ProductResourceFeedbackQueryBuilder> build)
    {
        AddField<ProductResourceFeedback, ProductResourceFeedbackQueryBuilder>("feedback", build);
        return this;
    }

    public BulkProductResourceFeedbackCreatePayloadQueryBuilder AddFieldUserErrors(Func<BulkProductResourceFeedbackCreateUserErrorQueryBuilder, BulkProductResourceFeedbackCreateUserErrorQueryBuilder> build)
    {
        AddField<BulkProductResourceFeedbackCreateUserError, BulkProductResourceFeedbackCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}