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

public class ShopifyPaymentsPayoutQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayout>("query shopifyPaymentsPayout")
{
    [Obsolete("Use `destinationAccount` instead.")]
    public ShopifyPaymentsPayoutQueryBuilder AddFieldBankAccount()
    {
        AddField("bankAccount");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldBusinessEntity()
    {
        AddField("businessEntity");
        return this;
    }

    [Obsolete("Use `net` instead.")]
    public ShopifyPaymentsPayoutQueryBuilder AddFieldGross()
    {
        AddField("gross");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldIssuedAt()
    {
        AddField("issuedAt");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldNet()
    {
        AddField("net");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public ShopifyPaymentsPayoutQueryBuilder AddFieldTransactionType()
    {
        AddField("transactionType");
        return this;
    }
}