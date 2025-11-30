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

public class CustomerShopPayAgreementQueryBuilder() : GraphQueryBuilder<CustomerShopPayAgreement>("customerShopPayAgreement")
{
    public CustomerShopPayAgreementQueryBuilder AddFieldBillingAddress(Func<CustomerCreditCardBillingAddressQueryBuilder, CustomerCreditCardBillingAddressQueryBuilder> build)
    {
        AddField<CustomerCreditCardBillingAddress, CustomerCreditCardBillingAddressQueryBuilder>("billingAddress", build);
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldExpiresSoon()
    {
        AddField("expiresSoon");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldExpiryMonth()
    {
        AddField("expiryMonth");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldExpiryYear()
    {
        AddField("expiryYear");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldInactive()
    {
        AddField("inactive");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldIsRevocable()
    {
        AddField("isRevocable");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldLastDigits()
    {
        AddField("lastDigits");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldMaskedNumber()
    {
        AddField("maskedNumber");
        return this;
    }

    public CustomerShopPayAgreementQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}