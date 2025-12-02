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

public class CustomerAccountAppExtensionPageQueryBuilder() : GraphQueryBuilder<CustomerAccountAppExtensionPage>("customerAccountAppExtensionPage")
{
    public CustomerAccountAppExtensionPageQueryBuilder AddFieldAppExtensionUuid()
    {
        AddField("appExtensionUuid");
        return this;
    }

    public CustomerAccountAppExtensionPageQueryBuilder AddFieldDefaultCursor()
    {
        AddField("defaultCursor");
        return this;
    }

    public CustomerAccountAppExtensionPageQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public CustomerAccountAppExtensionPageQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CustomerAccountAppExtensionPageQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}