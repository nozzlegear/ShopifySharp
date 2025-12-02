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

public class CarrierServiceCreatePayloadQueryBuilder() : GraphQueryBuilder<CarrierServiceCreatePayload>("carrierServiceCreatePayload")
{
    public CarrierServiceCreatePayloadQueryBuilder AddFieldCarrierService(Func<DeliveryCarrierServiceQueryBuilder, DeliveryCarrierServiceQueryBuilder> build)
    {
        AddField<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>("carrierService", build);
        return this;
    }

    public CarrierServiceCreatePayloadQueryBuilder AddFieldUserErrors(Func<CarrierServiceCreateUserErrorQueryBuilder, CarrierServiceCreateUserErrorQueryBuilder> build)
    {
        AddField<CarrierServiceCreateUserError, CarrierServiceCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}