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
    public sealed class QueryRootProductFeedsQueryBuilder : FieldsQueryBuilderBase<ProductFeedConnection, QueryRootProductFeedsQueryBuilder>, IHasArguments<QueryRootProductFeedsArgumentsBuilder>
    {
        public QueryRootProductFeedsArgumentsBuilder Arguments { get; }
        protected override QueryRootProductFeedsQueryBuilder Self => this;

        public QueryRootProductFeedsQueryBuilder(string name) : base(new Query<ProductFeedConnection>(name))
        {
            Arguments = new QueryRootProductFeedsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductFeedsQueryBuilder(IQuery<ProductFeedConnection> query) : base(query)
        {
            Arguments = new QueryRootProductFeedsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductFeedsQueryBuilder SetArguments(Action<QueryRootProductFeedsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductFeedsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedEdgeQueryBuilder> build)
        {
            var query = new Query<ProductFeedEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedEdge>(query);
            return this;
        }

        public QueryRootProductFeedsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeed>(query);
            return this;
        }

        public QueryRootProductFeedsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}