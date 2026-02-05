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
    public sealed class BlogConnectionQueryBuilder : FieldsQueryBuilderBase<BlogConnection, BlogConnectionQueryBuilder>
    {
        protected override BlogConnectionQueryBuilder Self => this;

        public BlogConnectionQueryBuilder() : this("blogConnection")
        {
        }

        public BlogConnectionQueryBuilder(string name) : base(new Query<BlogConnection>(name))
        {
        }

        public BlogConnectionQueryBuilder(IQuery<BlogConnection> query) : base(query)
        {
        }

        public BlogConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogEdgeQueryBuilder> build)
        {
            var query = new Query<BlogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogEdge>(query);
            return this;
        }

        public BlogConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public BlogConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}