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

public class FulfillmentOrderLocationForMoveQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLocationForMove>("query fulfillmentOrderLocationForMove")
{
    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldAvailableLineItems()
    {
        AddField("availableLineItems");
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldAvailableLineItemsCount()
    {
        AddField("availableLineItemsCount");
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldMovable()
    {
        AddField("movable");
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldUnavailableLineItems()
    {
        AddField("unavailableLineItems");
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldUnavailableLineItemsCount()
    {
        AddField("unavailableLineItemsCount");
        return this;
    }
}