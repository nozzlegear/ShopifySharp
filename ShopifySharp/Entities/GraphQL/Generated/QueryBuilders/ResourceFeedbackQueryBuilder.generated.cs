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

public class ResourceFeedbackQueryBuilder() : GraphQueryBuilder<ResourceFeedback>("resourceFeedback")
{
    public ResourceFeedbackQueryBuilder AddFieldAppFeedback(Func<AppFeedbackQueryBuilder, AppFeedbackQueryBuilder> build)
    {
        AddField<AppFeedback, AppFeedbackQueryBuilder>("appFeedback", build);
        return this;
    }

    public ResourceFeedbackQueryBuilder AddFieldDetails(Func<AppFeedbackQueryBuilder, AppFeedbackQueryBuilder> build)
    {
        AddField<AppFeedback, AppFeedbackQueryBuilder>("details", build);
        return this;
    }

    public ResourceFeedbackQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }
}