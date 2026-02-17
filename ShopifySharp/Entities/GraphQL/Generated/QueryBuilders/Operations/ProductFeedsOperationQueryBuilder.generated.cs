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
    public sealed class ProductFeedsOperationQueryBuilder : FieldsQueryBuilderBase<ProductFeedConnection, ProductFeedsOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductFeedConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductFeedsArgumentsBuilder Arguments { get; }
        protected override ProductFeedsOperationQueryBuilder Self => this;

        public ProductFeedsOperationQueryBuilder() : this("productFeeds")
        {
        }

        public ProductFeedsOperationQueryBuilder(string name) : base(new Query<ProductFeedConnection>(name))
        {
            Arguments = new ProductFeedsArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedsOperationQueryBuilder(IQuery<ProductFeedConnection> query) : base(query)
        {
            Arguments = new ProductFeedsArgumentsBuilder(base.InnerQuery);
        }

        public ProductFeedsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedEdgeQueryBuilder> build)
        {
            var query = new Query<ProductFeedEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedEdge>(query);
            return this;
        }

        public ProductFeedsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeed>(query);
            return this;
        }

        public ProductFeedsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}