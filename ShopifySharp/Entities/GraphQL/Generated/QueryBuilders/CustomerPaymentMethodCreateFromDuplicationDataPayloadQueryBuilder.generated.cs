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

public class CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreateFromDuplicationDataPayload>("customerPaymentMethodCreateFromDuplicationDataPayload")
{
    public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public CustomerPaymentMethodCreateFromDuplicationDataPayloadQueryBuilder AddFieldUserErrors(Func<CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder, CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder> build)
    {
        AddField<CustomerPaymentMethodCreateFromDuplicationDataUserError, CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}