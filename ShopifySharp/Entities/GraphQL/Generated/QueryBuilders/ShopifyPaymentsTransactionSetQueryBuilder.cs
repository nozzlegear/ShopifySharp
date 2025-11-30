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

public class ShopifyPaymentsTransactionSetQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsTransactionSet>("query shopifyPaymentsTransactionSet")
{
    public ShopifyPaymentsTransactionSetQueryBuilder AddFieldExtendedAuthorizationSet()
    {
        AddField("extendedAuthorizationSet");
        return this;
    }

    public ShopifyPaymentsTransactionSetQueryBuilder AddFieldRefundSet()
    {
        AddField("refundSet");
        return this;
    }
}