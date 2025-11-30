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

public class CustomerPaymentMethodPaypalBillingAgreementUpdateQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodPaypalBillingAgreementUpdatePayload>("query customerPaymentMethodPaypalBillingAgreementUpdate")
{
    public CustomerPaymentMethodPaypalBillingAgreementUpdateQueryBuilder AddArgumentBillingAddress(MailingAddressInput? billingAddress)
    {
        AddArgument("billingAddress", billingAddress);
        return this;
    }

    public CustomerPaymentMethodPaypalBillingAgreementUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}