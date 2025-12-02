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

public class DeliveryProvinceQueryBuilder() : GraphQueryBuilder<DeliveryProvince>("deliveryProvince")
{
    public DeliveryProvinceQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DeliveryProvinceQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryProvinceQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public DeliveryProvinceQueryBuilder AddFieldTranslatedName()
    {
        AddField("translatedName");
        return this;
    }
}