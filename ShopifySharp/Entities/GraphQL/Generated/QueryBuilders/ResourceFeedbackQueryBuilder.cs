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

public class ResourceFeedbackQueryBuilder() : GraphQueryBuilder<ResourceFeedback>("query resourceFeedback")
{
    [Obsolete("Use `details` instead.")]
    public ResourceFeedbackQueryBuilder AddFieldAppFeedback()
    {
        AddField("appFeedback");
        return this;
    }

    public ResourceFeedbackQueryBuilder AddFieldDetails()
    {
        AddField("details");
        return this;
    }

    public ResourceFeedbackQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }
}