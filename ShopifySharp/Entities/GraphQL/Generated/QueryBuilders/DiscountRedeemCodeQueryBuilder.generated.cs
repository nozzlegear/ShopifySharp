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

public class DiscountRedeemCodeQueryBuilder() : GraphQueryBuilder<DiscountRedeemCode>("discountRedeemCode")
{
    public DiscountRedeemCodeQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountRedeemCodeQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DiscountRedeemCodeQueryBuilder AddFieldCreatedBy(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("createdBy", build);
        return this;
    }

    public DiscountRedeemCodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}