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

public class DeliveryParticipantQueryBuilder() : GraphQueryBuilder<DeliveryParticipant>("deliveryParticipant")
{
    public DeliveryParticipantQueryBuilder AddFieldAdaptToNewServicesFlag()
    {
        AddField("adaptToNewServicesFlag");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldCarrierService(Func<DeliveryCarrierServiceQueryBuilder, DeliveryCarrierServiceQueryBuilder> build)
    {
        AddField<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>("carrierService", build);
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldFixedFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("fixedFee", build);
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldParticipantServices(Func<DeliveryParticipantServiceQueryBuilder, DeliveryParticipantServiceQueryBuilder> build)
    {
        AddField<DeliveryParticipantService, DeliveryParticipantServiceQueryBuilder>("participantServices", build);
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldPercentageOfRateFee()
    {
        AddField("percentageOfRateFee");
        return this;
    }
}