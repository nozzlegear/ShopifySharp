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

public class CommentSpamUserErrorQueryBuilder() : GraphQueryBuilder<CommentSpamUserError>("query commentSpamUserError")
{
    public CommentSpamUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CommentSpamUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CommentSpamUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}