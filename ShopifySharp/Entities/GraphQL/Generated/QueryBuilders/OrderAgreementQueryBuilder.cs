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

public class OrderAgreementQueryBuilder() : GraphQueryBuilder<OrderAgreement>("query orderAgreement")
{
    public OrderAgreementQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldSales()
    {
        AddField("sales");
        return this;
    }

    public OrderAgreementQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}