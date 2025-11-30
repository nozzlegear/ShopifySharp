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

public class DeliveryParticipantQueryBuilder() : GraphQueryBuilder<DeliveryParticipant>("query deliveryParticipant")
{
    public DeliveryParticipantQueryBuilder AddFieldAdaptToNewServicesFlag()
    {
        AddField("adaptToNewServicesFlag");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldCarrierService()
    {
        AddField("carrierService");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldFixedFee()
    {
        AddField("fixedFee");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldParticipantServices()
    {
        AddField("participantServices");
        return this;
    }

    public DeliveryParticipantQueryBuilder AddFieldPercentageOfRateFee()
    {
        AddField("percentageOfRateFee");
        return this;
    }
}