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

public class StoreCreditAccountCreditTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountCreditTransaction>("query storeCreditAccountCreditTransaction")
{
    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldAccount()
    {
        AddField("account");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldBalanceAfterTransaction()
    {
        AddField("balanceAfterTransaction");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldExpiresAt()
    {
        AddField("expiresAt");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldOrigin()
    {
        AddField("origin");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldRemainingAmount()
    {
        AddField("remainingAmount");
        return this;
    }
}