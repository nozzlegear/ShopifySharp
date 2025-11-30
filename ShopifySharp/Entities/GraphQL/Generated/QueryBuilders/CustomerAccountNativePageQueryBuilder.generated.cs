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

public class CustomerAccountNativePageQueryBuilder() : GraphQueryBuilder<CustomerAccountNativePage>("customerAccountNativePage")
{
    public CustomerAccountNativePageQueryBuilder AddFieldDefaultCursor()
    {
        AddField("defaultCursor");
        return this;
    }

    public CustomerAccountNativePageQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public CustomerAccountNativePageQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CustomerAccountNativePageQueryBuilder AddFieldPageType()
    {
        AddField("pageType");
        return this;
    }

    public CustomerAccountNativePageQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}