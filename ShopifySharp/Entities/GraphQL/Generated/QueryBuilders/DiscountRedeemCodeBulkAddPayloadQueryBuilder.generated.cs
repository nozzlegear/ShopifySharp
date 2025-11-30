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

public class DiscountRedeemCodeBulkAddPayloadQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeBulkAddPayload>("discountRedeemCodeBulkAddPayload")
{
    public DiscountRedeemCodeBulkAddPayloadQueryBuilder AddFieldBulkCreation(Func<DiscountRedeemCodeBulkCreationQueryBuilder, DiscountRedeemCodeBulkCreationQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeBulkCreation, DiscountRedeemCodeBulkCreationQueryBuilder>("bulkCreation", build);
        return this;
    }

    public DiscountRedeemCodeBulkAddPayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}