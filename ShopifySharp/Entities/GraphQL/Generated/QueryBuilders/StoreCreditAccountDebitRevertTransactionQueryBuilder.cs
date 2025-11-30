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

public class StoreCreditAccountDebitRevertTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountDebitRevertTransaction>("query storeCreditAccountDebitRevertTransaction")
{
    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldAccount()
    {
        AddField("account");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldBalanceAfterTransaction()
    {
        AddField("balanceAfterTransaction");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldDebitTransaction()
    {
        AddField("debitTransaction");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldOrigin()
    {
        AddField("origin");
        return this;
    }
}