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
    public sealed class AccessScopeQueryBuilder : FieldsQueryBuilderBase<AccessScope, AccessScopeQueryBuilder>
    {
        protected override AccessScopeQueryBuilder Self => this;

        public AccessScopeQueryBuilder() : this("accessScope")
        {
        }

        public AccessScopeQueryBuilder(string name) : base(new Query<AccessScope>(name))
        {
        }

        public AccessScopeQueryBuilder(IQuery<AccessScope> query) : base(query)
        {
        }

        public AccessScopeQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public AccessScopeQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }
    }
}