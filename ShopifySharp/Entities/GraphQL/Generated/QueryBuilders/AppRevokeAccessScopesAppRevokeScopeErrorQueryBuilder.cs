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

public class AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder() : GraphQueryBuilder<AppRevokeAccessScopesAppRevokeScopeError>("query appRevokeAccessScopesAppRevokeScopeError")
{
    public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}