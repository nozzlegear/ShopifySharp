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

public class ProductReorderMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductReorderMediaPayload>("productReorderMediaPayload")
{
    public ProductReorderMediaPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public ProductReorderMediaPayloadQueryBuilder AddFieldMediaUserErrors(Func<MediaUserErrorQueryBuilder, MediaUserErrorQueryBuilder> build)
    {
        AddField<MediaUserError, MediaUserErrorQueryBuilder>("mediaUserErrors", build);
        return this;
    }

    public ProductReorderMediaPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}