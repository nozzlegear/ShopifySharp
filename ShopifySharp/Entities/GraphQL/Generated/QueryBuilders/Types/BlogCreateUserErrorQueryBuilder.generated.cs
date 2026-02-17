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
    public sealed class BlogCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<BlogCreateUserError, BlogCreateUserErrorQueryBuilder>
    {
        protected override BlogCreateUserErrorQueryBuilder Self => this;

        public BlogCreateUserErrorQueryBuilder() : this("blogCreateUserError")
        {
        }

        public BlogCreateUserErrorQueryBuilder(string name) : base(new Query<BlogCreateUserError>(name))
        {
        }

        public BlogCreateUserErrorQueryBuilder(IQuery<BlogCreateUserError> query) : base(query)
        {
        }

        public BlogCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BlogCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BlogCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}