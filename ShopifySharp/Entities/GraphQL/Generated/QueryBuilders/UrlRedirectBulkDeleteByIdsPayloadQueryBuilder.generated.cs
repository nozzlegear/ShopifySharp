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

public class UrlRedirectBulkDeleteByIdsPayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteByIdsPayload>("urlRedirectBulkDeleteByIdsPayload")
{
    public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public UrlRedirectBulkDeleteByIdsPayloadQueryBuilder AddFieldUserErrors(Func<UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder, UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder> build)
    {
        AddField<UrlRedirectBulkDeleteByIdsUserError, UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}