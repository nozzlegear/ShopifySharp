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

public class CommentSpamPayloadQueryBuilder() : GraphQueryBuilder<CommentSpamPayload>("commentSpamPayload")
{
    public CommentSpamPayloadQueryBuilder AddFieldComment(Func<CommentQueryBuilder, CommentQueryBuilder> build)
    {
        AddField<Comment, CommentQueryBuilder>("comment", build);
        return this;
    }

    public CommentSpamPayloadQueryBuilder AddFieldUserErrors(Func<CommentSpamUserErrorQueryBuilder, CommentSpamUserErrorQueryBuilder> build)
    {
        AddField<CommentSpamUserError, CommentSpamUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}