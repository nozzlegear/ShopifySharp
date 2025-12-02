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

public class AppPurchaseOneTimeCreatePayloadQueryBuilder() : GraphQueryBuilder<AppPurchaseOneTimeCreatePayload>("appPurchaseOneTimeCreatePayload")
{
    public AppPurchaseOneTimeCreatePayloadQueryBuilder AddFieldAppPurchaseOneTime(Func<AppPurchaseOneTimeQueryBuilder, AppPurchaseOneTimeQueryBuilder> build)
    {
        AddField<AppPurchaseOneTime, AppPurchaseOneTimeQueryBuilder>("appPurchaseOneTime", build);
        return this;
    }

    public AppPurchaseOneTimeCreatePayloadQueryBuilder AddFieldConfirmationUrl()
    {
        AddField("confirmationUrl");
        return this;
    }

    public AppPurchaseOneTimeCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}