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

public class AppFeedbackQueryBuilder() : GraphQueryBuilder<AppFeedback>("appFeedback")
{
    public AppFeedbackQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldFeedbackGeneratedAt()
    {
        AddField("feedbackGeneratedAt");
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldLink(Func<LinkQueryBuilder, LinkQueryBuilder> build)
    {
        AddField<Link, LinkQueryBuilder>("link", build);
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldMessages(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("messages", build);
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldState()
    {
        AddField("state");
        return this;
    }
}