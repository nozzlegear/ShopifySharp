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

public class CustomerPaymentMethodEdgeQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodEdge>("customerPaymentMethodEdge")
{
    public CustomerPaymentMethodEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CustomerPaymentMethodEdgeQueryBuilder AddFieldNode(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("node", build);
        return this;
    }
}