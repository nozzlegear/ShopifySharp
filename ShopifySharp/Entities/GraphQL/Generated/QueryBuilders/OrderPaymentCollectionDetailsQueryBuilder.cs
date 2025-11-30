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

public class OrderPaymentCollectionDetailsQueryBuilder() : GraphQueryBuilder<OrderPaymentCollectionDetails>("query orderPaymentCollectionDetails")
{
    public OrderPaymentCollectionDetailsQueryBuilder AddFieldAdditionalPaymentCollectionUrl()
    {
        AddField("additionalPaymentCollectionUrl");
        return this;
    }

    public OrderPaymentCollectionDetailsQueryBuilder AddFieldVaultedPaymentMethods()
    {
        AddField("vaultedPaymentMethods");
        return this;
    }
}