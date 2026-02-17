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
    public sealed class DelegateAccessTokenCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<DelegateAccessTokenCreateUserError, DelegateAccessTokenCreateUserErrorQueryBuilder>
    {
        protected override DelegateAccessTokenCreateUserErrorQueryBuilder Self => this;

        public DelegateAccessTokenCreateUserErrorQueryBuilder() : this("delegateAccessTokenCreateUserError")
        {
        }

        public DelegateAccessTokenCreateUserErrorQueryBuilder(string name) : base(new Query<DelegateAccessTokenCreateUserError>(name))
        {
        }

        public DelegateAccessTokenCreateUserErrorQueryBuilder(IQuery<DelegateAccessTokenCreateUserError> query) : base(query)
        {
        }

        public DelegateAccessTokenCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DelegateAccessTokenCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DelegateAccessTokenCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}