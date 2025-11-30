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

public class RefundAgreementQueryBuilder() : GraphQueryBuilder<RefundAgreement>("query refundAgreement")
{
    public RefundAgreementQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldHappenedAt()
    {
        AddField("happenedAt");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldRefund()
    {
        AddField("refund");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldSales()
    {
        AddField("sales");
        return this;
    }

    public RefundAgreementQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}