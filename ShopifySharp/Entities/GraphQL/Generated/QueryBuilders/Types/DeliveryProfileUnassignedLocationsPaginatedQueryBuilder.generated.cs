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
    public sealed class DeliveryProfileUnassignedLocationsPaginatedQueryBuilder : FieldsQueryBuilderBase<LocationConnection, DeliveryProfileUnassignedLocationsPaginatedQueryBuilder>, IHasArguments<DeliveryProfileUnassignedLocationsPaginatedArgumentsBuilder>
    {
        public DeliveryProfileUnassignedLocationsPaginatedArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileUnassignedLocationsPaginatedQueryBuilder Self => this;

        public DeliveryProfileUnassignedLocationsPaginatedQueryBuilder(string name) : base(new Query<LocationConnection>(name))
        {
            Arguments = new DeliveryProfileUnassignedLocationsPaginatedArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileUnassignedLocationsPaginatedQueryBuilder(IQuery<LocationConnection> query) : base(query)
        {
            Arguments = new DeliveryProfileUnassignedLocationsPaginatedArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileUnassignedLocationsPaginatedQueryBuilder SetArguments(Action<DeliveryProfileUnassignedLocationsPaginatedArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryProfileUnassignedLocationsPaginatedQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationEdgeQueryBuilder> build)
        {
            var query = new Query<LocationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationEdge>(query);
            return this;
        }

        public DeliveryProfileUnassignedLocationsPaginatedQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public DeliveryProfileUnassignedLocationsPaginatedQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}