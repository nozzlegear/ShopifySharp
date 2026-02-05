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
    public sealed class BlogCreatePayloadQueryBuilder : FieldsQueryBuilderBase<BlogCreatePayload, BlogCreatePayloadQueryBuilder>
    {
        protected override BlogCreatePayloadQueryBuilder Self => this;

        public BlogCreatePayloadQueryBuilder() : this("blogCreatePayload")
        {
        }

        public BlogCreatePayloadQueryBuilder(string name) : base(new Query<BlogCreatePayload>(name))
        {
        }

        public BlogCreatePayloadQueryBuilder(IQuery<BlogCreatePayload> query) : base(query)
        {
        }

        public BlogCreatePayloadQueryBuilder Blog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("blog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public BlogCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<BlogCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogCreateUserError>(query);
            return this;
        }
    }
}