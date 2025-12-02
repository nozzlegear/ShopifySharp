#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopAlertQueryBuilder() : GraphQueryBuilder<ShopAlert>("shopAlert")
{
    public ShopAlertQueryBuilder AddFieldAction(Func<ShopAlertActionQueryBuilder, ShopAlertActionQueryBuilder> build)
    {
        AddField<ShopAlertAction, ShopAlertActionQueryBuilder>("action", build);
        return this;
    }

    public ShopAlertQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }
}