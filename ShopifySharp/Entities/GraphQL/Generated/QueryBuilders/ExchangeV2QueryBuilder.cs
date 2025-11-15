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

public class ExchangeV2QueryBuilder() : GraphQueryBuilder<ExchangeV2>("query exchangeV2")
{
    public ExchangeV2QueryBuilder AddFieldAdditions()
    {
        AddField("additions");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldCompletedAt()
    {
        AddField("completedAt");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldMirrored()
    {
        AddField("mirrored");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldRefunds()
    {
        AddField("refunds");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldReturns()
    {
        AddField("returns");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldStaffMember()
    {
        AddField("staffMember");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldTotalAmountProcessedSet()
    {
        AddField("totalAmountProcessedSet");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldTotalPriceSet()
    {
        AddField("totalPriceSet");
        return this;
    }

    public ExchangeV2QueryBuilder AddFieldTransactions()
    {
        AddField("transactions");
        return this;
    }
}