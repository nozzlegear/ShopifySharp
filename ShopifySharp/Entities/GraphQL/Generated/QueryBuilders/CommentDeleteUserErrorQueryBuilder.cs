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

public class CommentDeleteUserErrorQueryBuilder() : GraphQueryBuilder<CommentDeleteUserError>("query commentDeleteUserError")
{
    public CommentDeleteUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CommentDeleteUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CommentDeleteUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}