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

public class OrderPaymentCollectionDetailsQueryBuilder() : GraphQueryBuilder<OrderPaymentCollectionDetails>("orderPaymentCollectionDetails")
{
    public OrderPaymentCollectionDetailsQueryBuilder AddFieldAdditionalPaymentCollectionUrl()
    {
        AddField("additionalPaymentCollectionUrl");
        return this;
    }

    public OrderPaymentCollectionDetailsQueryBuilder AddFieldVaultedPaymentMethods(Func<PaymentMandateQueryBuilder, PaymentMandateQueryBuilder> build)
    {
        AddField<PaymentMandate, PaymentMandateQueryBuilder>("vaultedPaymentMethods", build);
        return this;
    }
}