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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DelegateAccessTokenDestroyUserErrorQueryBuilder : FieldsQueryBuilderBase<DelegateAccessTokenDestroyUserError, DelegateAccessTokenDestroyUserErrorQueryBuilder>
    {
        protected override DelegateAccessTokenDestroyUserErrorQueryBuilder Self => this;

        public DelegateAccessTokenDestroyUserErrorQueryBuilder() : this("delegateAccessTokenDestroyUserError")
        {
        }

        public DelegateAccessTokenDestroyUserErrorQueryBuilder(string name) : base(new Query<DelegateAccessTokenDestroyUserError>(name))
        {
        }

        public DelegateAccessTokenDestroyUserErrorQueryBuilder(IQuery<DelegateAccessTokenDestroyUserError> query) : base(query)
        {
        }

        public DelegateAccessTokenDestroyUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DelegateAccessTokenDestroyUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DelegateAccessTokenDestroyUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}