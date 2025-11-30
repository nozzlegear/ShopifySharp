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

public class CustomerPaymentMethodRemoteCreatePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodRemoteCreatePayload>("customerPaymentMethodRemoteCreatePayload")
{
    public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder AddFieldUserErrors(Func<CustomerPaymentMethodRemoteUserErrorQueryBuilder, CustomerPaymentMethodRemoteUserErrorQueryBuilder> build)
    {
        AddField<CustomerPaymentMethodRemoteUserError, CustomerPaymentMethodRemoteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}