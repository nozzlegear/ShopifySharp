#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class AppRevokeAccessScopesPayloadQueryBuilder : FieldsQueryBuilderBase<AppRevokeAccessScopesPayload, AppRevokeAccessScopesPayloadQueryBuilder>
    {
        protected override AppRevokeAccessScopesPayloadQueryBuilder Self => this;

        public AppRevokeAccessScopesPayloadQueryBuilder() : this("appRevokeAccessScopesPayload")
        {
        }

        public AppRevokeAccessScopesPayloadQueryBuilder(string name) : base(new Query<AppRevokeAccessScopesPayload>(name))
        {
        }

        public AppRevokeAccessScopesPayloadQueryBuilder(IQuery<AppRevokeAccessScopesPayload> query) : base(query)
        {
        }

        public AppRevokeAccessScopesPayloadQueryBuilder Revoked(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("revoked");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppRevokeAccessScopesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder> build)
        {
            var query = new Query<AppRevokeAccessScopesAppRevokeScopeError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevokeAccessScopesAppRevokeScopeError>(query);
            return this;
        }
    }
}