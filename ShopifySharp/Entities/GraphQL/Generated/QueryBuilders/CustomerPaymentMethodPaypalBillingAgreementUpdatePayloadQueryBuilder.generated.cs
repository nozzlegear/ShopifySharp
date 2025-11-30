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

public class CustomerPaymentMethodPaypalBillingAgreementUpdatePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload>("customerPaymentMethodPaypalBillingAgreementUpdatePayload")
{
    public CustomerPaymentMethodPaypalBillingAgreementUpdatePayloadQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public CustomerPaymentMethodPaypalBillingAgreementUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CustomerPaymentMethodUserErrorQueryBuilder, CustomerPaymentMethodUserErrorQueryBuilder> build)
    {
        AddField<CustomerPaymentMethodUserError, CustomerPaymentMethodUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}