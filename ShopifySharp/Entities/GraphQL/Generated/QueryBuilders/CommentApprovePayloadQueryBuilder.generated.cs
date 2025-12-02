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

public class CommentApprovePayloadQueryBuilder() : GraphQueryBuilder<CommentApprovePayload>("commentApprovePayload")
{
    public CommentApprovePayloadQueryBuilder AddFieldComment(Func<CommentQueryBuilder, CommentQueryBuilder> build)
    {
        AddField<Comment, CommentQueryBuilder>("comment", build);
        return this;
    }

    public CommentApprovePayloadQueryBuilder AddFieldUserErrors(Func<CommentApproveUserErrorQueryBuilder, CommentApproveUserErrorQueryBuilder> build)
    {
        AddField<CommentApproveUserError, CommentApproveUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}