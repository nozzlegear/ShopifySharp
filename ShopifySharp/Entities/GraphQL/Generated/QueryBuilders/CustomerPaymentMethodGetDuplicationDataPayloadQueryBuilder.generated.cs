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

public class CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodGetDuplicationDataPayload>("customerPaymentMethodGetDuplicationDataPayload")
{
    public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder AddFieldEncryptedDuplicationData()
    {
        AddField("encryptedDuplicationData");
        return this;
    }

    public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder AddFieldUserErrors(Func<CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder, CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder> build)
    {
        AddField<CustomerPaymentMethodGetDuplicationDataUserError, CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}