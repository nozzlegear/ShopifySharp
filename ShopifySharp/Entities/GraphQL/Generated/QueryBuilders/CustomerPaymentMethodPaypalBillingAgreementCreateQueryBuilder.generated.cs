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

public class CustomerPaymentMethodPaypalBillingAgreementCreateQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodPaypalBillingAgreementCreatePayload>("customerPaymentMethodPaypalBillingAgreementCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CustomerPaymentMethodPaypalBillingAgreementCreateQueryBuilder AddArgumentBillingAddress(MailingAddressInput? billingAddress)
    {
        AddArgument("billingAddress", billingAddress);
        return this;
    }

    public CustomerPaymentMethodPaypalBillingAgreementCreateQueryBuilder AddArgumentBillingAgreementId(string? billingAgreementId)
    {
        AddArgument("billingAgreementId", billingAgreementId);
        return this;
    }

    public CustomerPaymentMethodPaypalBillingAgreementCreateQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerPaymentMethodPaypalBillingAgreementCreateQueryBuilder AddArgumentInactive(bool? inactive)
    {
        AddArgument("inactive", inactive);
        return this;
    }
}