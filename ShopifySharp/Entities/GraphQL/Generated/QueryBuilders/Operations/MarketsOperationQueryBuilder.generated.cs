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
    public sealed class MarketsOperationQueryBuilder : FieldsQueryBuilderBase<MarketConnection, MarketsOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketsArgumentsBuilder Arguments { get; }
        protected override MarketsOperationQueryBuilder Self => this;

        public MarketsOperationQueryBuilder() : this("markets")
        {
        }

        public MarketsOperationQueryBuilder(string name) : base(new Query<MarketConnection>(name))
        {
            Arguments = new MarketsArgumentsBuilder(base.InnerQuery);
        }

        public MarketsOperationQueryBuilder(IQuery<MarketConnection> query) : base(query)
        {
            Arguments = new MarketsArgumentsBuilder(base.InnerQuery);
        }

        public MarketsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder> build)
        {
            var query = new Query<MarketEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketEdge>(query);
            return this;
        }

        public MarketsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}