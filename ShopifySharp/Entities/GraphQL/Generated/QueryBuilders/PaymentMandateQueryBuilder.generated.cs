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

public class PaymentMandateQueryBuilder() : GraphQueryBuilder<PaymentMandate>("paymentMandate")
{
    public PaymentMandateQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PaymentMandateQueryBuilder AddUnionCasePaymentInstrument(Func<VaultCreditCardQueryBuilder, VaultCreditCardQueryBuilder> build)
    {
        AddUnion<VaultCreditCard, VaultCreditCardQueryBuilder>("paymentInstrument", build);
        return this;
    }

    public PaymentMandateQueryBuilder AddUnionCasePaymentInstrument(Func<VaultPaypalBillingAgreementQueryBuilder, VaultPaypalBillingAgreementQueryBuilder> build)
    {
        AddUnion<VaultPaypalBillingAgreement, VaultPaypalBillingAgreementQueryBuilder>("paymentInstrument", build);
        return this;
    }
}