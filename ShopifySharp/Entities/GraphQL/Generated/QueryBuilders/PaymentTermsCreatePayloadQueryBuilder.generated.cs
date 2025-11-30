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

public class PaymentTermsCreatePayloadQueryBuilder() : GraphQueryBuilder<PaymentTermsCreatePayload>("paymentTermsCreatePayload")
{
    public PaymentTermsCreatePayloadQueryBuilder AddFieldPaymentTerms(Func<PaymentTermsQueryBuilder, PaymentTermsQueryBuilder> build)
    {
        AddField<PaymentTerms, PaymentTermsQueryBuilder>("paymentTerms", build);
        return this;
    }

    public PaymentTermsCreatePayloadQueryBuilder AddFieldUserErrors(Func<PaymentTermsCreateUserErrorQueryBuilder, PaymentTermsCreateUserErrorQueryBuilder> build)
    {
        AddField<PaymentTermsCreateUserError, PaymentTermsCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}