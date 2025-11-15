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

public class CustomerPaymentMethodCreateFromDuplicationDataQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreateFromDuplicationDataPayload>("query customerPaymentMethodCreateFromDuplicationData")
{
    public CustomerPaymentMethodCreateFromDuplicationDataQueryBuilder AddArgumentBillingAddress(MailingAddressInput? billingAddress)
    {
        AddArgument("billingAddress", billingAddress);
        return this;
    }

    public CustomerPaymentMethodCreateFromDuplicationDataQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerPaymentMethodCreateFromDuplicationDataQueryBuilder AddArgumentEncryptedDuplicationData(string? encryptedDuplicationData)
    {
        AddArgument("encryptedDuplicationData", encryptedDuplicationData);
        return this;
    }
}