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

public class OrderEditAgreementQueryBuilder() : GraphQueryBuilder<OrderEditAgreement>("query orderEditAgreement")
{
    public OrderEditAgreementQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldSales()
    {
        AddField("sales");
        return this;
    }

    public OrderEditAgreementQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}