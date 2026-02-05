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
    public sealed class AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder : FieldsQueryBuilderBase<AppRevokeAccessScopesAppRevokeScopeError, AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder>
    {
        protected override AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder Self => this;

        public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder() : this("appRevokeAccessScopesAppRevokeScopeError")
        {
        }

        public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder(string name) : base(new Query<AppRevokeAccessScopesAppRevokeScopeError>(name))
        {
        }

        public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder(IQuery<AppRevokeAccessScopesAppRevokeScopeError> query) : base(query)
        {
        }

        public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public AppRevokeAccessScopesAppRevokeScopeErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}