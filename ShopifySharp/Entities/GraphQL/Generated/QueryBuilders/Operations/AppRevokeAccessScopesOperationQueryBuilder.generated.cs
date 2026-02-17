#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AppRevokeAccessScopesOperationQueryBuilder : FieldsQueryBuilderBase<AppRevokeAccessScopesPayload, AppRevokeAccessScopesOperationQueryBuilder>, IGraphOperationQueryBuilder<AppRevokeAccessScopesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppRevokeAccessScopesArgumentsBuilder Arguments { get; }
        protected override AppRevokeAccessScopesOperationQueryBuilder Self => this;

        public AppRevokeAccessScopesOperationQueryBuilder() : this("appRevokeAccessScopes")
        {
        }

        public AppRevokeAccessScopesOperationQueryBuilder(string name) : base(new Query<AppRevokeAccessScopesPayload>(name))
        {
            Arguments = new AppRevokeAccessScopesArgumentsBuilder(base.InnerQuery);
        }

        public AppRevokeAccessScopesOperationQueryBuilder(IQuery<AppRevokeAccessScopesPayload> query) : base(query)
        {
            Arguments = new AppRevokeAccessScopesArgumentsBuilder(base.InnerQuery);
        }

        public AppRevokeAccessScopesOperationQueryBuilder Revoked(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder> build)
        {
            var query = new Query<AccessScope>("revoked");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AccessScopeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AccessScope>(query);
            return this;
        }

        public AppRevokeAccessScopesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder> build)
        {
            var query = new Query<AppRevokeAccessScopesAppRevokeScopeError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppRevokeAccessScopesAppRevokeScopeError>(query);
            return this;
        }
    }
}