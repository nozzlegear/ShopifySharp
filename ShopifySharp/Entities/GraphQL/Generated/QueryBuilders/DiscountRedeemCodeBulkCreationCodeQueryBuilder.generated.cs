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

public class DiscountRedeemCodeBulkCreationCodeQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeBulkCreationCode>("discountRedeemCodeBulkCreationCode")
{
    public DiscountRedeemCodeBulkCreationCodeQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DiscountRedeemCodeBulkCreationCodeQueryBuilder AddFieldDiscountRedeemCode(Func<DiscountRedeemCodeQueryBuilder, DiscountRedeemCodeQueryBuilder> build)
    {
        AddField<DiscountRedeemCode, DiscountRedeemCodeQueryBuilder>("discountRedeemCode", build);
        return this;
    }

    public DiscountRedeemCodeBulkCreationCodeQueryBuilder AddFieldErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("errors", build);
        return this;
    }
}