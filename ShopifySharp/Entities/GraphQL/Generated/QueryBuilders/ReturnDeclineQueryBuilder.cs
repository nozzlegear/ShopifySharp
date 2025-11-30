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

public class ReturnDeclineQueryBuilder() : GraphQueryBuilder<ReturnDecline>("query returnDecline")
{
    public ReturnDeclineQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public ReturnDeclineQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }
}