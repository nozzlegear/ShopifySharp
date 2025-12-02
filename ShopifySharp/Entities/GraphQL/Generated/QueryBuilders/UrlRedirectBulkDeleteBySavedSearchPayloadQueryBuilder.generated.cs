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

public class UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteBySavedSearchPayload>("urlRedirectBulkDeleteBySavedSearchPayload")
{
    public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public UrlRedirectBulkDeleteBySavedSearchPayloadQueryBuilder AddFieldUserErrors(Func<UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder, UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder> build)
    {
        AddField<UrlRedirectBulkDeleteBySavedSearchUserError, UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}