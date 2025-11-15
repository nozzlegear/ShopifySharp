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

public class DataSaleOptOutQueryBuilder() : GraphQueryBuilder<DataSaleOptOutPayload>("query dataSaleOptOut")
{
    public DataSaleOptOutQueryBuilder AddArgumentEmail(string? email)
    {
        AddArgument("email", email);
        return this;
    }
}