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

public class CustomerPaypalBillingAgreementQueryBuilder() : GraphQueryBuilder<CustomerPaypalBillingAgreement>("query customerPaypalBillingAgreement")
{
    public CustomerPaypalBillingAgreementQueryBuilder AddFieldBillingAddress()
    {
        AddField("billingAddress");
        return this;
    }

    public CustomerPaypalBillingAgreementQueryBuilder AddFieldInactive()
    {
        AddField("inactive");
        return this;
    }

    public CustomerPaypalBillingAgreementQueryBuilder AddFieldIsRevocable()
    {
        AddField("isRevocable");
        return this;
    }

    public CustomerPaypalBillingAgreementQueryBuilder AddFieldPaypalAccountEmail()
    {
        AddField("paypalAccountEmail");
        return this;
    }
}