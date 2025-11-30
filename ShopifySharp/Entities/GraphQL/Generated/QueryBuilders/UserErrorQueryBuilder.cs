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

public class UserErrorQueryBuilder() : GraphQueryBuilder<UserError>("query userError")
{
    public UserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public UserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}