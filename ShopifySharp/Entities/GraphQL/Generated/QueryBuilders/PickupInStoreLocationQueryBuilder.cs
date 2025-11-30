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

public class PickupInStoreLocationQueryBuilder() : GraphQueryBuilder<PickupInStoreLocation>("query pickupInStoreLocation")
{
    public PickupInStoreLocationQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PickupInStoreLocationQueryBuilder AddFieldDistanceFromBuyer()
    {
        AddField("distanceFromBuyer");
        return this;
    }

    public PickupInStoreLocationQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public PickupInStoreLocationQueryBuilder AddFieldInstructions()
    {
        AddField("instructions");
        return this;
    }

    public PickupInStoreLocationQueryBuilder AddFieldLocationId()
    {
        AddField("locationId");
        return this;
    }

    public PickupInStoreLocationQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public PickupInStoreLocationQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}