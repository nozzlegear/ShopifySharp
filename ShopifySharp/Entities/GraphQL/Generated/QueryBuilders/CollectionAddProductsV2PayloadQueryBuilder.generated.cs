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

public class CollectionAddProductsV2PayloadQueryBuilder() : GraphQueryBuilder<CollectionAddProductsV2Payload>("collectionAddProductsV2Payload")
{
    public CollectionAddProductsV2PayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public CollectionAddProductsV2PayloadQueryBuilder AddFieldUserErrors(Func<CollectionAddProductsV2UserErrorQueryBuilder, CollectionAddProductsV2UserErrorQueryBuilder> build)
    {
        AddField<CollectionAddProductsV2UserError, CollectionAddProductsV2UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}