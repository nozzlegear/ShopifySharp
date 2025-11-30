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

public class ShopifyPaymentsTransactionSetQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsTransactionSet>("shopifyPaymentsTransactionSet")
{
    public ShopifyPaymentsTransactionSetQueryBuilder AddFieldExtendedAuthorizationSet(Func<ShopifyPaymentsExtendedAuthorizationQueryBuilder, ShopifyPaymentsExtendedAuthorizationQueryBuilder> build)
    {
        AddField<ShopifyPaymentsExtendedAuthorization, ShopifyPaymentsExtendedAuthorizationQueryBuilder>("extendedAuthorizationSet", build);
        return this;
    }

    public ShopifyPaymentsTransactionSetQueryBuilder AddFieldRefundSet(Func<ShopifyPaymentsRefundSetQueryBuilder, ShopifyPaymentsRefundSetQueryBuilder> build)
    {
        AddField<ShopifyPaymentsRefundSet, ShopifyPaymentsRefundSetQueryBuilder>("refundSet", build);
        return this;
    }
}