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

public class ProductJoinSellingPlanGroupsPayloadQueryBuilder() : GraphQueryBuilder<ProductJoinSellingPlanGroupsPayload>("productJoinSellingPlanGroupsPayload")
{
    public ProductJoinSellingPlanGroupsPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductJoinSellingPlanGroupsPayloadQueryBuilder AddFieldUserErrors(Func<SellingPlanGroupUserErrorQueryBuilder, SellingPlanGroupUserErrorQueryBuilder> build)
    {
        AddField<SellingPlanGroupUserError, SellingPlanGroupUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}