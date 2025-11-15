#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload>("query shopifyPaymentsPayoutAlternateCurrencyCreatePayload")
{
    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder AddFieldPayout()
    {
        AddField("payout");
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder AddFieldSuccess()
    {
        AddField("success");
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}