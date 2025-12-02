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

public class ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload>("shopifyPaymentsPayoutAlternateCurrencyCreatePayload")
{
    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder AddFieldPayout(Func<ShopifyPaymentsToolingProviderPayoutQueryBuilder, ShopifyPaymentsToolingProviderPayoutQueryBuilder> build)
    {
        AddField<ShopifyPaymentsToolingProviderPayout, ShopifyPaymentsToolingProviderPayoutQueryBuilder>("payout", build);
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder AddFieldSuccess()
    {
        AddField("success");
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder AddFieldUserErrors(Func<ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder, ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError, ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}