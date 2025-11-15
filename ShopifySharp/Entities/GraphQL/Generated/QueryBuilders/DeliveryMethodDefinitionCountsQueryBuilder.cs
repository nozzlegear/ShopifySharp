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

public class DeliveryMethodDefinitionCountsQueryBuilder() : GraphQueryBuilder<DeliveryMethodDefinitionCounts>("query deliveryMethodDefinitionCounts")
{
    public DeliveryMethodDefinitionCountsQueryBuilder AddFieldParticipantDefinitionsCount()
    {
        AddField("participantDefinitionsCount");
        return this;
    }

    public DeliveryMethodDefinitionCountsQueryBuilder AddFieldRateDefinitionsCount()
    {
        AddField("rateDefinitionsCount");
        return this;
    }
}