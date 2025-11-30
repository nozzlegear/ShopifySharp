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

public class IStoreCreditAccountTransactionQueryBuilder() : GraphQueryBuilder<IStoreCreditAccountTransaction>("query iStoreCreditAccountTransaction")
{
    public IStoreCreditAccountTransactionQueryBuilder AddFieldAccount()
    {
        AddField("account");
        return this;
    }

    public IStoreCreditAccountTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public IStoreCreditAccountTransactionQueryBuilder AddFieldBalanceAfterTransaction()
    {
        AddField("balanceAfterTransaction");
        return this;
    }

    public IStoreCreditAccountTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public IStoreCreditAccountTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public IStoreCreditAccountTransactionQueryBuilder AddFieldOrigin()
    {
        AddField("origin");
        return this;
    }
}