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

public class CommentEventAttachmentQueryBuilder() : GraphQueryBuilder<CommentEventAttachment>("query commentEventAttachment")
{
    public CommentEventAttachmentQueryBuilder AddFieldFileExtension()
    {
        AddField("fileExtension");
        return this;
    }

    public CommentEventAttachmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CommentEventAttachmentQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public CommentEventAttachmentQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public CommentEventAttachmentQueryBuilder AddFieldSize()
    {
        AddField("size");
        return this;
    }

    public CommentEventAttachmentQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}