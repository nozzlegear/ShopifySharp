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
    public sealed class BlogDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<BlogDeleteUserError, BlogDeleteUserErrorQueryBuilder>
    {
        protected override BlogDeleteUserErrorQueryBuilder Self => this;

        public BlogDeleteUserErrorQueryBuilder() : this("blogDeleteUserError")
        {
        }

        public BlogDeleteUserErrorQueryBuilder(string name) : base(new Query<BlogDeleteUserError>(name))
        {
        }

        public BlogDeleteUserErrorQueryBuilder(IQuery<BlogDeleteUserError> query) : base(query)
        {
        }

        public BlogDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public BlogDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public BlogDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}