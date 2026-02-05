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
    public sealed class BlogDeletePayloadQueryBuilder : FieldsQueryBuilderBase<BlogDeletePayload, BlogDeletePayloadQueryBuilder>
    {
        protected override BlogDeletePayloadQueryBuilder Self => this;

        public BlogDeletePayloadQueryBuilder() : this("blogDeletePayload")
        {
        }

        public BlogDeletePayloadQueryBuilder(string name) : base(new Query<BlogDeletePayload>(name))
        {
        }

        public BlogDeletePayloadQueryBuilder(IQuery<BlogDeletePayload> query) : base(query)
        {
        }

        public BlogDeletePayloadQueryBuilder DeletedBlogId()
        {
            base.InnerQuery.AddField("deletedBlogId");
            return this;
        }

        public BlogDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<BlogDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogDeleteUserError>(query);
            return this;
        }
    }
}