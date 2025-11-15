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

public class DataSaleOptOutUserErrorQueryBuilder() : GraphQueryBuilder<DataSaleOptOutUserError>("query dataSaleOptOutUserError")
{
    public DataSaleOptOutUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DataSaleOptOutUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DataSaleOptOutUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}