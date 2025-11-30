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

public class InventoryShipmentTrackingQueryBuilder() : GraphQueryBuilder<InventoryShipmentTracking>("inventoryShipmentTracking")
{
    public InventoryShipmentTrackingQueryBuilder AddFieldArrivesAt()
    {
        AddField("arrivesAt");
        return this;
    }

    public InventoryShipmentTrackingQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public InventoryShipmentTrackingQueryBuilder AddFieldTrackingNumber()
    {
        AddField("trackingNumber");
        return this;
    }

    public InventoryShipmentTrackingQueryBuilder AddFieldTrackingUrl()
    {
        AddField("trackingUrl");
        return this;
    }
}