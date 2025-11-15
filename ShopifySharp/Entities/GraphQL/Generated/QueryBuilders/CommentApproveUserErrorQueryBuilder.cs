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

public class CommentApproveUserErrorQueryBuilder() : GraphQueryBuilder<CommentApproveUserError>("query commentApproveUserError")
{
    public CommentApproveUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CommentApproveUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CommentApproveUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}