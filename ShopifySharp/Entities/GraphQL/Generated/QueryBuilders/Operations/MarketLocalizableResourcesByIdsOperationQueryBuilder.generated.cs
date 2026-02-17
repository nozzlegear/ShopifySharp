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
    public sealed class MarketLocalizableResourcesByIdsOperationQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResourceConnection, MarketLocalizableResourcesByIdsOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketLocalizableResourceConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketLocalizableResourcesByIdsArgumentsBuilder Arguments { get; }
        protected override MarketLocalizableResourcesByIdsOperationQueryBuilder Self => this;

        public MarketLocalizableResourcesByIdsOperationQueryBuilder() : this("marketLocalizableResourcesByIds")
        {
        }

        public MarketLocalizableResourcesByIdsOperationQueryBuilder(string name) : base(new Query<MarketLocalizableResourceConnection>(name))
        {
            Arguments = new MarketLocalizableResourcesByIdsArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourcesByIdsOperationQueryBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
            Arguments = new MarketLocalizableResourcesByIdsArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourcesByIdsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResourceEdge>(query);
            return this;
        }

        public MarketLocalizableResourcesByIdsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResource>(query);
            return this;
        }

        public MarketLocalizableResourcesByIdsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}