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

public class UnitPriceMeasurementQueryBuilder() : GraphQueryBuilder<UnitPriceMeasurement>("query unitPriceMeasurement")
{
    public UnitPriceMeasurementQueryBuilder AddFieldMeasuredType()
    {
        AddField("measuredType");
        return this;
    }

    public UnitPriceMeasurementQueryBuilder AddFieldQuantityUnit()
    {
        AddField("quantityUnit");
        return this;
    }

    public UnitPriceMeasurementQueryBuilder AddFieldQuantityValue()
    {
        AddField("quantityValue");
        return this;
    }

    public UnitPriceMeasurementQueryBuilder AddFieldReferenceUnit()
    {
        AddField("referenceUnit");
        return this;
    }

    public UnitPriceMeasurementQueryBuilder AddFieldReferenceValue()
    {
        AddField("referenceValue");
        return this;
    }
}