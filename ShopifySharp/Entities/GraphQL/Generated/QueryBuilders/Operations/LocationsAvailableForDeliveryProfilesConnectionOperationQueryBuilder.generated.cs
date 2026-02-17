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
    public sealed class LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder : FieldsQueryBuilderBase<LocationConnection, LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder Arguments { get; }
        protected override LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder Self => this;

        public LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder() : this("locationsAvailableForDeliveryProfilesConnection")
        {
        }

        public LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder(string name) : base(new Query<LocationConnection>(name))
        {
            Arguments = new LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder(base.InnerQuery);
        }

        public LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder(IQuery<LocationConnection> query) : base(query)
        {
            Arguments = new LocationsAvailableForDeliveryProfilesConnectionArgumentsBuilder(base.InnerQuery);
        }

        public LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationEdgeQueryBuilder> build)
        {
            var query = new Query<LocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationEdge>(query);
            return this;
        }

        public LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationsAvailableForDeliveryProfilesConnectionOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}