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

public class DutySaleQueryBuilder() : GraphQueryBuilder<DutySale>("query dutySale")
{
    public DutySaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public DutySaleQueryBuilder AddFieldDuty()
    {
        AddField("duty");
        return this;
    }

    public DutySaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DutySaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public DutySaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public DutySaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}