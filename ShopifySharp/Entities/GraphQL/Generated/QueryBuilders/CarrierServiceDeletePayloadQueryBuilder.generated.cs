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

public class CarrierServiceDeletePayloadQueryBuilder() : GraphQueryBuilder<CarrierServiceDeletePayload>("carrierServiceDeletePayload")
{
    public CarrierServiceDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public CarrierServiceDeletePayloadQueryBuilder AddFieldUserErrors(Func<CarrierServiceDeleteUserErrorQueryBuilder, CarrierServiceDeleteUserErrorQueryBuilder> build)
    {
        AddField<CarrierServiceDeleteUserError, CarrierServiceDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}