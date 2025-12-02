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

public class ShopifyPaymentsBankAccountEdgeQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBankAccountEdge>("shopifyPaymentsBankAccountEdge")
{
    public ShopifyPaymentsBankAccountEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ShopifyPaymentsBankAccountEdgeQueryBuilder AddFieldNode(Func<ShopifyPaymentsBankAccountQueryBuilder, ShopifyPaymentsBankAccountQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBankAccount, ShopifyPaymentsBankAccountQueryBuilder>("node", build);
        return this;
    }
}