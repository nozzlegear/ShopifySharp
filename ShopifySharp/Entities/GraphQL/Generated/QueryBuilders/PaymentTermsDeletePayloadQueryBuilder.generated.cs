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

public class PaymentTermsDeletePayloadQueryBuilder() : GraphQueryBuilder<PaymentTermsDeletePayload>("paymentTermsDeletePayload")
{
    public PaymentTermsDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public PaymentTermsDeletePayloadQueryBuilder AddFieldUserErrors(Func<PaymentTermsDeleteUserErrorQueryBuilder, PaymentTermsDeleteUserErrorQueryBuilder> build)
    {
        AddField<PaymentTermsDeleteUserError, PaymentTermsDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}