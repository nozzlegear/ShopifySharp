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
    public sealed class PriceListsOperationQueryBuilder : FieldsQueryBuilderBase<PriceListConnection, PriceListsOperationQueryBuilder>, IGraphOperationQueryBuilder<PriceListConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PriceListsArgumentsBuilder Arguments { get; }
        protected override PriceListsOperationQueryBuilder Self => this;

        public PriceListsOperationQueryBuilder() : this("priceLists")
        {
        }

        public PriceListsOperationQueryBuilder(string name) : base(new Query<PriceListConnection>(name))
        {
            Arguments = new PriceListsArgumentsBuilder(base.InnerQuery);
        }

        public PriceListsOperationQueryBuilder(IQuery<PriceListConnection> query) : base(query)
        {
            Arguments = new PriceListsArgumentsBuilder(base.InnerQuery);
        }

        public PriceListsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListEdgeQueryBuilder> build)
        {
            var query = new Query<PriceListEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceListEdge>(query);
            return this;
        }

        public PriceListsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        public PriceListsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}