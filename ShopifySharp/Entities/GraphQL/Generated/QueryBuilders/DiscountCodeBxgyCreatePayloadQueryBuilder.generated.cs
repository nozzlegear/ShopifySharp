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

public class DiscountCodeBxgyCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeBxgyCreatePayload>("discountCodeBxgyCreatePayload")
{
    public DiscountCodeBxgyCreatePayloadQueryBuilder AddFieldCodeDiscountNode(Func<DiscountCodeNodeQueryBuilder, DiscountCodeNodeQueryBuilder> build)
    {
        AddField<DiscountCodeNode, DiscountCodeNodeQueryBuilder>("codeDiscountNode", build);
        return this;
    }

    public DiscountCodeBxgyCreatePayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}