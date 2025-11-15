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

public class CommentEventQueryBuilder() : GraphQueryBuilder<CommentEvent>("query commentEvent")
{
    public CommentEventQueryBuilder AddFieldAction()
    {
        AddField("action");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAppTitle()
    {
        AddField("appTitle");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAttachments()
    {
        AddField("attachments");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAttributeToApp()
    {
        AddField("attributeToApp");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAttributeToUser()
    {
        AddField("attributeToUser");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAuthor()
    {
        AddField("author");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCanDelete()
    {
        AddField("canDelete");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCanEdit()
    {
        AddField("canEdit");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCriticalAlert()
    {
        AddField("criticalAlert");
        return this;
    }

    public CommentEventQueryBuilder AddFieldEdited()
    {
        AddField("edited");
        return this;
    }

    public CommentEventQueryBuilder AddFieldEmbed()
    {
        AddField("embed");
        return this;
    }

    public CommentEventQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CommentEventQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public CommentEventQueryBuilder AddFieldRawMessage()
    {
        AddField("rawMessage");
        return this;
    }

    public CommentEventQueryBuilder AddFieldSubject()
    {
        AddField("subject");
        return this;
    }
}