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

public class FulfillmentOrderAssignedLocationQueryBuilder() : GraphQueryBuilder<FulfillmentOrderAssignedLocation>("query fulfillmentOrderAssignedLocation")
{
    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public FulfillmentOrderAssignedLocationQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}