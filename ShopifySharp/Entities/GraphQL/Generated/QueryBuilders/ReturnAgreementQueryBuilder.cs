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

public class ReturnAgreementQueryBuilder() : GraphQueryBuilder<ReturnAgreement>("query returnAgreement")
{
    public ReturnAgreementQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldReturn()
    {
        AddField("return");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldSales()
    {
        AddField("sales");
        return this;
    }

    public ReturnAgreementQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}