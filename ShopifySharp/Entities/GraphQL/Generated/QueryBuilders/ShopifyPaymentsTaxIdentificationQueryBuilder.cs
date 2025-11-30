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

public class ShopifyPaymentsTaxIdentificationQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsTaxIdentification>("query shopifyPaymentsTaxIdentification")
{
    public ShopifyPaymentsTaxIdentificationQueryBuilder AddFieldTaxIdentificationType()
    {
        AddField("taxIdentificationType");
        return this;
    }

    public ShopifyPaymentsTaxIdentificationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}