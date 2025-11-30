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

public class DiscountCodeFreeShippingUpdatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShippingUpdatePayload>("discountCodeFreeShippingUpdatePayload")
{
    public DiscountCodeFreeShippingUpdatePayloadQueryBuilder AddFieldCodeDiscountNode(Func<DiscountCodeNodeQueryBuilder, DiscountCodeNodeQueryBuilder> build)
    {
        AddField<DiscountCodeNode, DiscountCodeNodeQueryBuilder>("codeDiscountNode", build);
        return this;
    }

    public DiscountCodeFreeShippingUpdatePayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}