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

public class CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodGetDuplicationDataPayload>("query customerPaymentMethodGetDuplicationDataPayload")
{
    public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder AddFieldEncryptedDuplicationData()
    {
        AddField("encryptedDuplicationData");
        return this;
    }

    public CustomerPaymentMethodGetDuplicationDataPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}