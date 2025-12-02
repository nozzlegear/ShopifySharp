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

public class CommentEventSubjectQueryBuilder() : GraphQueryBuilder<ICommentEventSubject>("commentEventSubject")
{
    public CommentEventSubjectQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public CommentEventSubjectQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}