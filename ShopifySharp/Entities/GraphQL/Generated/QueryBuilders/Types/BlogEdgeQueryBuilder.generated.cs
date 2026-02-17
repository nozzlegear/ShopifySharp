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
    public sealed class BlogEdgeQueryBuilder : FieldsQueryBuilderBase<BlogEdge, BlogEdgeQueryBuilder>
    {
        protected override BlogEdgeQueryBuilder Self => this;

        public BlogEdgeQueryBuilder() : this("blogEdge")
        {
        }

        public BlogEdgeQueryBuilder(string name) : base(new Query<BlogEdge>(name))
        {
        }

        public BlogEdgeQueryBuilder(IQuery<BlogEdge> query) : base(query)
        {
        }

        public BlogEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public BlogEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }
    }
}