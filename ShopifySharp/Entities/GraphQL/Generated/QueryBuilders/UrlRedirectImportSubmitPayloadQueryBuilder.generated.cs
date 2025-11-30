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

public class UrlRedirectImportSubmitPayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectImportSubmitPayload>("urlRedirectImportSubmitPayload")
{
    public UrlRedirectImportSubmitPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public UrlRedirectImportSubmitPayloadQueryBuilder AddFieldUserErrors(Func<UrlRedirectImportUserErrorQueryBuilder, UrlRedirectImportUserErrorQueryBuilder> build)
    {
        AddField<UrlRedirectImportUserError, UrlRedirectImportUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}