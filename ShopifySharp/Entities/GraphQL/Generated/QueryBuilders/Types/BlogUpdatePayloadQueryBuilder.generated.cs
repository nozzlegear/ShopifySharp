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
    public sealed class BlogUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<BlogUpdatePayload, BlogUpdatePayloadQueryBuilder>
    {
        protected override BlogUpdatePayloadQueryBuilder Self => this;

        public BlogUpdatePayloadQueryBuilder() : this("blogUpdatePayload")
        {
        }

        public BlogUpdatePayloadQueryBuilder(string name) : base(new Query<BlogUpdatePayload>(name))
        {
        }

        public BlogUpdatePayloadQueryBuilder(IQuery<BlogUpdatePayload> query) : base(query)
        {
        }

        public BlogUpdatePayloadQueryBuilder Blog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("blog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public BlogUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<BlogUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogUpdateUserError>(query);
            return this;
        }
    }
}