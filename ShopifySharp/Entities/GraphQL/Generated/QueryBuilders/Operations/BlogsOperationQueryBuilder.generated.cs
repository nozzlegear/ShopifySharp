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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class BlogsOperationQueryBuilder : FieldsQueryBuilderBase<BlogConnection, BlogsOperationQueryBuilder>, IGraphOperationQueryBuilder<BlogConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public BlogsArgumentsBuilder Arguments { get; }
        protected override BlogsOperationQueryBuilder Self => this;

        public BlogsOperationQueryBuilder() : this("blogs")
        {
        }

        public BlogsOperationQueryBuilder(string name) : base(new Query<BlogConnection>(name))
        {
            Arguments = new BlogsArgumentsBuilder(base.InnerQuery);
        }

        public BlogsOperationQueryBuilder(IQuery<BlogConnection> query) : base(query)
        {
            Arguments = new BlogsArgumentsBuilder(base.InnerQuery);
        }

        public BlogsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogEdgeQueryBuilder> build)
        {
            var query = new Query<BlogEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogEdge>(query);
            return this;
        }

        public BlogsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public BlogsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}