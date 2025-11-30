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

public class PaymentTermsCreateQueryBuilder() : GraphQueryBuilder<PaymentTermsCreatePayload>("query paymentTermsCreate")
{
    public PaymentTermsCreateQueryBuilder AddArgumentPaymentTermsAttributes(PaymentTermsCreateInput? paymentTermsAttributes)
    {
        AddArgument("paymentTermsAttributes", paymentTermsAttributes);
        return this;
    }

    public PaymentTermsCreateQueryBuilder AddArgumentReferenceId(string? referenceId)
    {
        AddArgument("referenceId", referenceId);
        return this;
    }
}