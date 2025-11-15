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

public class StoreCreditAccountExpirationTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountExpirationTransaction>("query storeCreditAccountExpirationTransaction")
{
    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldAccount()
    {
        AddField("account");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldBalanceAfterTransaction()
    {
        AddField("balanceAfterTransaction");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldCreditTransaction()
    {
        AddField("creditTransaction");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldOrigin()
    {
        AddField("origin");
        return this;
    }
}