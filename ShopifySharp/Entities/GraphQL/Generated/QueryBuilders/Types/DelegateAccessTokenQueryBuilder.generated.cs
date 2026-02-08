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
    public sealed class DelegateAccessTokenQueryBuilder : FieldsQueryBuilderBase<DelegateAccessToken, DelegateAccessTokenQueryBuilder>
    {
        protected override DelegateAccessTokenQueryBuilder Self => this;

        public DelegateAccessTokenQueryBuilder() : this("delegateAccessToken")
        {
        }

        public DelegateAccessTokenQueryBuilder(string name) : base(new Query<DelegateAccessToken>(name))
        {
        }

        public DelegateAccessTokenQueryBuilder(IQuery<DelegateAccessToken> query) : base(query)
        {
        }

        public DelegateAccessTokenQueryBuilder AccessScopes()
        {
            base.InnerQuery.AddField("accessScopes");
            return this;
        }

        public DelegateAccessTokenQueryBuilder AccessToken()
        {
            base.InnerQuery.AddField("accessToken");
            return this;
        }

        public DelegateAccessTokenQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }
    }
}