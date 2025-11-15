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

public class ShopAlertQueryBuilder() : GraphQueryBuilder<ShopAlert>("query shopAlert")
{
    public ShopAlertQueryBuilder AddFieldAction()
    {
        AddField("action");
        return this;
    }

    public ShopAlertQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }
}