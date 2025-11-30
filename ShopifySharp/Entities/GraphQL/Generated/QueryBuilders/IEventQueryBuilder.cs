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

public class IEventQueryBuilder() : GraphQueryBuilder<IEvent>("query iEvent")
{
    public IEventQueryBuilder AddFieldAction()
    {
        AddField("action");
        return this;
    }

    public IEventQueryBuilder AddFieldAppTitle()
    {
        AddField("appTitle");
        return this;
    }

    public IEventQueryBuilder AddFieldAttributeToApp()
    {
        AddField("attributeToApp");
        return this;
    }

    public IEventQueryBuilder AddFieldAttributeToUser()
    {
        AddField("attributeToUser");
        return this;
    }

    public IEventQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public IEventQueryBuilder AddFieldCriticalAlert()
    {
        AddField("criticalAlert");
        return this;
    }

    public IEventQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IEventQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}