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

public class DeliveryAvailableServiceQueryBuilder() : GraphQueryBuilder<DeliveryAvailableService>("query deliveryAvailableService")
{
    public DeliveryAvailableServiceQueryBuilder AddFieldCountries()
    {
        AddField("countries");
        return this;
    }

    public DeliveryAvailableServiceQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}