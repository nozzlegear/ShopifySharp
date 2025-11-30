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

public class CommentDeletePayloadQueryBuilder() : GraphQueryBuilder<CommentDeletePayload>("query commentDeletePayload")
{
    public CommentDeletePayloadQueryBuilder AddFieldDeletedCommentId()
    {
        AddField("deletedCommentId");
        return this;
    }

    public CommentDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}