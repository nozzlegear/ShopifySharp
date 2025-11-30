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

public class TenderTransactionQueryBuilder() : GraphQueryBuilder<TenderTransaction>("query tenderTransaction")
{
    public TenderTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldPaymentMethod()
    {
        AddField("paymentMethod");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldProcessedAt()
    {
        AddField("processedAt");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldRemoteReference()
    {
        AddField("remoteReference");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldTransactionDetails()
    {
        AddField("transactionDetails");
        return this;
    }

    public TenderTransactionQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}