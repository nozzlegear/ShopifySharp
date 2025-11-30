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

public class AppRevokeAccessScopesQueryBuilder() : GraphQueryBuilder<AppRevokeAccessScopesPayload>("query appRevokeAccessScopes")
{
    public AppRevokeAccessScopesQueryBuilder AddArgumentScopes(ICollection<string>? scopes)
    {
        AddArgument("scopes", scopes);
        return this;
    }
}