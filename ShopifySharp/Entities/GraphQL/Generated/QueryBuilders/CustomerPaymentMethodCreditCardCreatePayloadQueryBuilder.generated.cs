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

public class CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreditCardCreatePayload>("customerPaymentMethodCreditCardCreatePayload")
{
    public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder AddFieldProcessing()
    {
        AddField("processing");
        return this;
    }

    public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}