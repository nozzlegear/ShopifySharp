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
    public sealed class BlogUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<BlogUpdateUserError, BlogUpdateUserErrorQueryBuilder>
    {
        protected override BlogUpdateUserErrorQueryBuilder Self => this;

        public BlogUpdateUserErrorQueryBuilder() : this("blogUpdateUserError")
        {
        }

        public BlogUpdateUserErrorQueryBuilder(string name) : base(new Query<BlogUpdateUserError>(name))
        {
        }

        public BlogUpdateUserErrorQueryBuilder(IQuery<BlogUpdateUserError> query) : base(query)
        {
        }

        public BlogUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BlogUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BlogUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}