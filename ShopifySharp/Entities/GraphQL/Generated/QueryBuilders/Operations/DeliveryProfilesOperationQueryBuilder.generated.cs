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
    public sealed class DeliveryProfilesOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileConnection, DeliveryProfilesOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryProfileConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeliveryProfilesArgumentsBuilder Arguments { get; }
        protected override DeliveryProfilesOperationQueryBuilder Self => this;

        public DeliveryProfilesOperationQueryBuilder() : this("deliveryProfiles")
        {
        }

        public DeliveryProfilesOperationQueryBuilder(string name) : base(new Query<DeliveryProfileConnection>(name))
        {
            Arguments = new DeliveryProfilesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfilesOperationQueryBuilder(IQuery<DeliveryProfileConnection> query) : base(query)
        {
            Arguments = new DeliveryProfilesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfilesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileEdge>(query);
            return this;
        }

        public DeliveryProfilesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public DeliveryProfilesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}