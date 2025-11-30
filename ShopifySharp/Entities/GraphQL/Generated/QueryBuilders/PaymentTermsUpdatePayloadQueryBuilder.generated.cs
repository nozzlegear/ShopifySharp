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

public class PaymentTermsUpdatePayloadQueryBuilder() : GraphQueryBuilder<PaymentTermsUpdatePayload>("paymentTermsUpdatePayload")
{
    public PaymentTermsUpdatePayloadQueryBuilder AddFieldPaymentTerms(Func<PaymentTermsQueryBuilder, PaymentTermsQueryBuilder> build)
    {
        AddField<PaymentTerms, PaymentTermsQueryBuilder>("paymentTerms", build);
        return this;
    }

    public PaymentTermsUpdatePayloadQueryBuilder AddFieldUserErrors(Func<PaymentTermsUpdateUserErrorQueryBuilder, PaymentTermsUpdateUserErrorQueryBuilder> build)
    {
        AddField<PaymentTermsUpdateUserError, PaymentTermsUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}