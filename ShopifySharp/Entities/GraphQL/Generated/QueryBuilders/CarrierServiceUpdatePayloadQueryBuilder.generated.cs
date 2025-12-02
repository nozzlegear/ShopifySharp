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

public class CarrierServiceUpdatePayloadQueryBuilder() : GraphQueryBuilder<CarrierServiceUpdatePayload>("carrierServiceUpdatePayload")
{
    public CarrierServiceUpdatePayloadQueryBuilder AddFieldCarrierService(Func<DeliveryCarrierServiceQueryBuilder, DeliveryCarrierServiceQueryBuilder> build)
    {
        AddField<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>("carrierService", build);
        return this;
    }

    public CarrierServiceUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CarrierServiceUpdateUserErrorQueryBuilder, CarrierServiceUpdateUserErrorQueryBuilder> build)
    {
        AddField<CarrierServiceUpdateUserError, CarrierServiceUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}