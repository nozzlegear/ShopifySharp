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

public class ICommentEventSubjectQueryBuilder() : GraphQueryBuilder<ICommentEventSubject>("query iCommentEventSubject")
{
    public ICommentEventSubjectQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public ICommentEventSubjectQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}