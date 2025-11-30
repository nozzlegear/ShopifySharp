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

public class CommentNotSpamPayloadQueryBuilder() : GraphQueryBuilder<CommentNotSpamPayload>("commentNotSpamPayload")
{
    public CommentNotSpamPayloadQueryBuilder AddFieldComment(Func<CommentQueryBuilder, CommentQueryBuilder> build)
    {
        AddField<Comment, CommentQueryBuilder>("comment", build);
        return this;
    }

    public CommentNotSpamPayloadQueryBuilder AddFieldUserErrors(Func<CommentNotSpamUserErrorQueryBuilder, CommentNotSpamUserErrorQueryBuilder> build)
    {
        AddField<CommentNotSpamUserError, CommentNotSpamUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}