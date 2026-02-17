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
    public sealed class MarketLocalizableResourcesOperationQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResourceConnection, MarketLocalizableResourcesOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketLocalizableResourceConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketLocalizableResourcesArgumentsBuilder Arguments { get; }
        protected override MarketLocalizableResourcesOperationQueryBuilder Self => this;

        public MarketLocalizableResourcesOperationQueryBuilder() : this("marketLocalizableResources")
        {
        }

        public MarketLocalizableResourcesOperationQueryBuilder(string name) : base(new Query<MarketLocalizableResourceConnection>(name))
        {
            Arguments = new MarketLocalizableResourcesArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourcesOperationQueryBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
            Arguments = new MarketLocalizableResourcesArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourcesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResourceEdge>(query);
            return this;
        }

        public MarketLocalizableResourcesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResource>(query);
            return this;
        }

        public MarketLocalizableResourcesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}