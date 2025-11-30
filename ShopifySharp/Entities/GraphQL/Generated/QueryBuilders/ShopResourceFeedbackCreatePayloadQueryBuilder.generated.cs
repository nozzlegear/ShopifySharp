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

public class ShopResourceFeedbackCreatePayloadQueryBuilder() : GraphQueryBuilder<ShopResourceFeedbackCreatePayload>("shopResourceFeedbackCreatePayload")
{
    public ShopResourceFeedbackCreatePayloadQueryBuilder AddFieldFeedback(Func<AppFeedbackQueryBuilder, AppFeedbackQueryBuilder> build)
    {
        AddField<AppFeedback, AppFeedbackQueryBuilder>("feedback", build);
        return this;
    }

    public ShopResourceFeedbackCreatePayloadQueryBuilder AddFieldUserErrors(Func<ShopResourceFeedbackCreateUserErrorQueryBuilder, ShopResourceFeedbackCreateUserErrorQueryBuilder> build)
    {
        AddField<ShopResourceFeedbackCreateUserError, ShopResourceFeedbackCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}