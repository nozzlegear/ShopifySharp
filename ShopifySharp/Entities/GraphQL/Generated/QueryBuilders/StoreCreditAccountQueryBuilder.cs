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

public class StoreCreditAccountQueryBuilder() : GraphQueryBuilder<StoreCreditAccount>("query storeCreditAccount")
{
    public StoreCreditAccountQueryBuilder AddFieldBalance()
    {
        AddField("balance");
        return this;
    }

    public StoreCreditAccountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountQueryBuilder AddFieldOwner()
    {
        AddField("owner");
        return this;
    }

    public StoreCreditAccountQueryBuilder AddFieldTransactions()
    {
        AddField("transactions");
        return this;
    }
}