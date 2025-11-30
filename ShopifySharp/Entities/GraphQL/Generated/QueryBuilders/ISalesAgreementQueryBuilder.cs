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

public class ISalesAgreementQueryBuilder() : GraphQueryBuilder<ISalesAgreement>("query iSalesAgreement")
{
    public ISalesAgreementQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public ISalesAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public ISalesAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ISalesAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public ISalesAgreementQueryBuilder AddFieldSales()
    {
        AddField("sales");
        return this;
    }

    public ISalesAgreementQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}