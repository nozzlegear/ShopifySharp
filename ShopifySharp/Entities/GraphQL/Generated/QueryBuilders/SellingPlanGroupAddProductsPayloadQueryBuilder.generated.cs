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

public class SellingPlanGroupAddProductsPayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupAddProductsPayload>("sellingPlanGroupAddProductsPayload")
{
    public SellingPlanGroupAddProductsPayloadQueryBuilder AddFieldSellingPlanGroup(Func<SellingPlanGroupQueryBuilder, SellingPlanGroupQueryBuilder> build)
    {
        AddField<SellingPlanGroup, SellingPlanGroupQueryBuilder>("sellingPlanGroup", build);
        return this;
    }

    public SellingPlanGroupAddProductsPayloadQueryBuilder AddFieldUserErrors(Func<SellingPlanGroupUserErrorQueryBuilder, SellingPlanGroupUserErrorQueryBuilder> build)
    {
        AddField<SellingPlanGroupUserError, SellingPlanGroupUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}