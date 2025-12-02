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

public class CombinedListingUpdatePayloadQueryBuilder() : GraphQueryBuilder<CombinedListingUpdatePayload>("combinedListingUpdatePayload")
{
    public CombinedListingUpdatePayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public CombinedListingUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CombinedListingUpdateUserErrorQueryBuilder, CombinedListingUpdateUserErrorQueryBuilder> build)
    {
        AddField<CombinedListingUpdateUserError, CombinedListingUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}