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

public class UrlRedirectBulkDeleteBySearchPayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteBySearchPayload>("urlRedirectBulkDeleteBySearchPayload")
{
    public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public UrlRedirectBulkDeleteBySearchPayloadQueryBuilder AddFieldUserErrors(Func<UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder, UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder> build)
    {
        AddField<UrlRedirectBulkDeleteBySearchUserError, UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}