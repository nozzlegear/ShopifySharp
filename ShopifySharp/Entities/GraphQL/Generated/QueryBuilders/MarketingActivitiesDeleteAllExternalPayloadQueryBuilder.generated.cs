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

public class MarketingActivitiesDeleteAllExternalPayloadQueryBuilder() : GraphQueryBuilder<MarketingActivitiesDeleteAllExternalPayload>("marketingActivitiesDeleteAllExternalPayload")
{
    public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public MarketingActivitiesDeleteAllExternalPayloadQueryBuilder AddFieldUserErrors(Func<MarketingActivityUserErrorQueryBuilder, MarketingActivityUserErrorQueryBuilder> build)
    {
        AddField<MarketingActivityUserError, MarketingActivityUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}