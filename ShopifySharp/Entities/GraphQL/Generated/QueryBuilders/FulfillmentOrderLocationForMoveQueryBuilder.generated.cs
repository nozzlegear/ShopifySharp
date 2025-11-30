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

public class FulfillmentOrderLocationForMoveQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLocationForMove>("fulfillmentOrderLocationForMove")
{
    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldAvailableLineItems(Func<FulfillmentOrderLineItemConnectionQueryBuilder, FulfillmentOrderLineItemConnectionQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItemConnection, FulfillmentOrderLineItemConnectionQueryBuilder>("availableLineItems", build);
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldAvailableLineItemsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("availableLineItemsCount", build);
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
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

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldUnavailableLineItems(Func<FulfillmentOrderLineItemConnectionQueryBuilder, FulfillmentOrderLineItemConnectionQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItemConnection, FulfillmentOrderLineItemConnectionQueryBuilder>("unavailableLineItems", build);
        return this;
    }

    public FulfillmentOrderLocationForMoveQueryBuilder AddFieldUnavailableLineItemsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("unavailableLineItemsCount", build);
        return this;
    }
}