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

public class StoreCreditAccountCreditPayloadQueryBuilder() : GraphQueryBuilder<StoreCreditAccountCreditPayload>("query storeCreditAccountCreditPayload")
{
    public StoreCreditAccountCreditPayloadQueryBuilder AddFieldStoreCreditAccountTransaction()
    {
        AddField("storeCreditAccountTransaction");
        return this;
    }

    public StoreCreditAccountCreditPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}