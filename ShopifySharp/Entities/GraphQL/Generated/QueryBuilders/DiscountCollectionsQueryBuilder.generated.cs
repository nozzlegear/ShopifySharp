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

public class DiscountCollectionsQueryBuilder() : GraphQueryBuilder<DiscountCollections>("discountCollections")
{
    public DiscountCollectionsQueryBuilder AddFieldCollections(Func<CollectionConnectionQueryBuilder, CollectionConnectionQueryBuilder> build)
    {
        AddField<CollectionConnection, CollectionConnectionQueryBuilder>("collections", build);
        return this;
    }
}