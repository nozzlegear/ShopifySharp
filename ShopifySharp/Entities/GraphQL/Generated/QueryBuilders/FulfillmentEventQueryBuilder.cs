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

public class FulfillmentEventQueryBuilder() : GraphQueryBuilder<FulfillmentEvent>("query fulfillmentEvent")
{
    public FulfillmentEventQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldEstimatedDeliveryAt()
    {
        AddField("estimatedDeliveryAt");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldLatitude()
    {
        AddField("latitude");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldLongitude()
    {
        AddField("longitude");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public FulfillmentEventQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}