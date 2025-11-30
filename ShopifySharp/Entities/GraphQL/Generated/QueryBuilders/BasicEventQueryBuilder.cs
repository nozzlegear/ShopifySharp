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

public class BasicEventQueryBuilder() : GraphQueryBuilder<BasicEvent>("query basicEvent")
{
    public BasicEventQueryBuilder AddFieldAction()
    {
        AddField("action");
        return this;
    }

    public BasicEventQueryBuilder AddFieldAdditionalContent()
    {
        AddField("additionalContent");
        return this;
    }

    public BasicEventQueryBuilder AddFieldAdditionalData()
    {
        AddField("additionalData");
        return this;
    }

    public BasicEventQueryBuilder AddFieldAppTitle()
    {
        AddField("appTitle");
        return this;
    }

    public BasicEventQueryBuilder AddFieldArguments()
    {
        AddField("arguments");
        return this;
    }

    public BasicEventQueryBuilder AddFieldAttributeToApp()
    {
        AddField("attributeToApp");
        return this;
    }

    public BasicEventQueryBuilder AddFieldAttributeToUser()
    {
        AddField("attributeToUser");
        return this;
    }

    public BasicEventQueryBuilder AddFieldAuthor()
    {
        AddField("author");
        return this;
    }

    public BasicEventQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public BasicEventQueryBuilder AddFieldCriticalAlert()
    {
        AddField("criticalAlert");
        return this;
    }

    public BasicEventQueryBuilder AddFieldHasAdditionalContent()
    {
        AddField("hasAdditionalContent");
        return this;
    }

    public BasicEventQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public BasicEventQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public BasicEventQueryBuilder AddFieldSecondaryMessage()
    {
        AddField("secondaryMessage");
        return this;
    }

    public BasicEventQueryBuilder AddFieldSubject()
    {
        AddField("subject");
        return this;
    }

    public BasicEventQueryBuilder AddFieldSubjectId()
    {
        AddField("subjectId");
        return this;
    }

    public BasicEventQueryBuilder AddFieldSubjectType()
    {
        AddField("subjectType");
        return this;
    }
}