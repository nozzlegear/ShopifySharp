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

public class SellingPlanGroupDeletePayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupDeletePayload>("sellingPlanGroupDeletePayload")
{
    public SellingPlanGroupDeletePayloadQueryBuilder AddFieldDeletedSellingPlanGroupId()
    {
        AddField("deletedSellingPlanGroupId");
        return this;
    }

    public SellingPlanGroupDeletePayloadQueryBuilder AddFieldUserErrors(Func<SellingPlanGroupUserErrorQueryBuilder, SellingPlanGroupUserErrorQueryBuilder> build)
    {
        AddField<SellingPlanGroupUserError, SellingPlanGroupUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}