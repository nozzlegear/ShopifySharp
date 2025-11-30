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

public class StoreCreditAccountDebitTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountDebitTransaction>("query storeCreditAccountDebitTransaction")
{
    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldAccount()
    {
        AddField("account");
        return this;
    }

    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldBalanceAfterTransaction()
    {
        AddField("balanceAfterTransaction");
        return this;
    }

    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountDebitTransactionQueryBuilder AddFieldOrigin()
    {
        AddField("origin");
        return this;
    }
}