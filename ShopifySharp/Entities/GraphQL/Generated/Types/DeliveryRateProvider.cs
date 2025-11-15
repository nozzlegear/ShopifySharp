#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A rate provided by a merchant-defined rate or a participant.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DeliveryRateProvider>))]
public record DeliveryRateProvider : GraphQLObject<DeliveryRateProvider>, IGraphQLUnionType
{
    public DeliveryParticipant? AsDeliveryParticipant() => this is DeliveryRateProviderDeliveryParticipant wrapper ? wrapper.Value : null;
    public DeliveryRateDefinition? AsDeliveryRateDefinition() => this is DeliveryRateProviderDeliveryRateDefinition wrapper ? wrapper.Value : null;
}