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

public class AppRevokeAccessScopesPayloadQueryBuilder() : GraphQueryBuilder<AppRevokeAccessScopesPayload>("appRevokeAccessScopesPayload")
{
    public AppRevokeAccessScopesPayloadQueryBuilder AddFieldRevoked(Func<AccessScopeQueryBuilder, AccessScopeQueryBuilder> build)
    {
        AddField<AccessScope, AccessScopeQueryBuilder>("revoked", build);
        return this;
    }

    public AppRevokeAccessScopesPayloadQueryBuilder AddFieldUserErrors(Func<AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder, AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder> build)
    {
        AddField<AppRevokeAccessScopesAppRevokeScopeError, AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder>("userErrors", build);
        return this;
    }
}