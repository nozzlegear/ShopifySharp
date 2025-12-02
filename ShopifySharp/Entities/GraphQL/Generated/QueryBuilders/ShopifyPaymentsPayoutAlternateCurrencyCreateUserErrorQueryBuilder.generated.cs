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

public class ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutAlternateCurrencyCreateUserError>("shopifyPaymentsPayoutAlternateCurrencyCreateUserError")
{
    public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}