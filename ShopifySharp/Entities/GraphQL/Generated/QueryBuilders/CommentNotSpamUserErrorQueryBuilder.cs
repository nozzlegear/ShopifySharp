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

public class CommentNotSpamUserErrorQueryBuilder() : GraphQueryBuilder<CommentNotSpamUserError>("query commentNotSpamUserError")
{
    public CommentNotSpamUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CommentNotSpamUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CommentNotSpamUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}