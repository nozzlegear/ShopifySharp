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

public class ErrorsWebPixelUserErrorQueryBuilder() : GraphQueryBuilder<ErrorsWebPixelUserError>("query errorsWebPixelUserError")
{
    public ErrorsWebPixelUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ErrorsWebPixelUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ErrorsWebPixelUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}