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

public class AppFeedbackQueryBuilder() : GraphQueryBuilder<AppFeedback>("query appFeedback")
{
    public AppFeedbackQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldFeedbackGeneratedAt()
    {
        AddField("feedbackGeneratedAt");
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldLink()
    {
        AddField("link");
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldMessages()
    {
        AddField("messages");
        return this;
    }

    public AppFeedbackQueryBuilder AddFieldState()
    {
        AddField("state");
        return this;
    }
}