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

public class CarrierServiceCreatePayloadQueryBuilder() : GraphQueryBuilder<CarrierServiceCreatePayload>("query carrierServiceCreatePayload")
{
    public CarrierServiceCreatePayloadQueryBuilder AddFieldCarrierService()
    {
        AddField("carrierService");
        return this;
    }

    public CarrierServiceCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}