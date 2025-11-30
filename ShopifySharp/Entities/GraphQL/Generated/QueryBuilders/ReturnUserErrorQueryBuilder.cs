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

public class ReturnUserErrorQueryBuilder() : GraphQueryBuilder<ReturnUserError>("query returnUserError")
{
    public ReturnUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ReturnUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ReturnUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}