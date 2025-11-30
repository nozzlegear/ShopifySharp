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

public class CustomerCancelDataErasurePayloadQueryBuilder() : GraphQueryBuilder<CustomerCancelDataErasurePayload>("customerCancelDataErasurePayload")
{
    public CustomerCancelDataErasurePayloadQueryBuilder AddFieldCustomerId()
    {
        AddField("customerId");
        return this;
    }

    public CustomerCancelDataErasurePayloadQueryBuilder AddFieldUserErrors(Func<CustomerCancelDataErasureUserErrorQueryBuilder, CustomerCancelDataErasureUserErrorQueryBuilder> build)
    {
        AddField<CustomerCancelDataErasureUserError, CustomerCancelDataErasureUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}