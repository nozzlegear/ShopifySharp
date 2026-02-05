#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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

        public DeliveryProfilesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileEdge>(query);
            return this;
        }

        public DeliveryProfilesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public DeliveryProfilesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}