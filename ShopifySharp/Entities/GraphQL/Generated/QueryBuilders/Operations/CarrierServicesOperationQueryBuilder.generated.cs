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
    public sealed class CarrierServicesOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierServiceConnection, CarrierServicesOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCarrierServiceConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CarrierServicesArgumentsBuilder Arguments { get; }
        protected override CarrierServicesOperationQueryBuilder Self => this;

        public CarrierServicesOperationQueryBuilder() : this("carrierServices")
        {
        }

        public CarrierServicesOperationQueryBuilder(string name) : base(new Query<DeliveryCarrierServiceConnection>(name))
        {
            Arguments = new CarrierServicesArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServicesOperationQueryBuilder(IQuery<DeliveryCarrierServiceConnection> query) : base(query)
        {
            Arguments = new CarrierServicesArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServicesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierServiceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierServiceEdge>(query);
            return this;
        }

        public CarrierServicesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public CarrierServicesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}