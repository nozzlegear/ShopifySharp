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

public class CombinedListingQueryBuilder() : GraphQueryBuilder<CombinedListing>("combinedListing")
{
    public CombinedListingQueryBuilder AddFieldCombinedListingChildren(Func<CombinedListingChildConnectionQueryBuilder, CombinedListingChildConnectionQueryBuilder> build)
    {
        AddField<CombinedListingChildConnection, CombinedListingChildConnectionQueryBuilder>("combinedListingChildren", build);
        return this;
    }

    public CombinedListingQueryBuilder AddFieldParentProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("parentProduct", build);
        return this;
    }
}