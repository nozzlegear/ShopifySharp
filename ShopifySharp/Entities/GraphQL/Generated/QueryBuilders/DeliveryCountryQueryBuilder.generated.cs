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

public class DeliveryCountryQueryBuilder() : GraphQueryBuilder<DeliveryCountry>("deliveryCountry")
{
    public DeliveryCountryQueryBuilder AddFieldCode(Func<DeliveryCountryCodeOrRestOfWorldQueryBuilder, DeliveryCountryCodeOrRestOfWorldQueryBuilder> build)
    {
        AddField<DeliveryCountryCodeOrRestOfWorld, DeliveryCountryCodeOrRestOfWorldQueryBuilder>("code", build);
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

    public DeliveryCountryQueryBuilder AddFieldProvinces(Func<DeliveryProvinceQueryBuilder, DeliveryProvinceQueryBuilder> build)
    {
        AddField<DeliveryProvince, DeliveryProvinceQueryBuilder>("provinces", build);
        return this;
    }

    public DeliveryCountryQueryBuilder AddFieldTranslatedName()
    {
        AddField("translatedName");
        return this;
    }
}