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

public class DeliveryCountryQueryBuilder() : GraphQueryBuilder<DeliveryCountry>("query deliveryCountry")
{
    public DeliveryCountryQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DeliveryCountryQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryCountryQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public DeliveryCountryQueryBuilder AddFieldProvinces()
    {
        AddField("provinces");
        return this;
    }

    public DeliveryCountryQueryBuilder AddFieldTranslatedName()
    {
        AddField("translatedName");
        return this;
    }
}