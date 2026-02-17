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
    public sealed class AvailableCarrierServicesOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierServiceAndLocations, AvailableCarrierServicesOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCarrierServiceAndLocations>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override AvailableCarrierServicesOperationQueryBuilder Self => this;

        public AvailableCarrierServicesOperationQueryBuilder() : this("availableCarrierServices")
        {
        }

        public AvailableCarrierServicesOperationQueryBuilder(string name) : base(new Query<DeliveryCarrierServiceAndLocations>(name))
        {
        }

        public AvailableCarrierServicesOperationQueryBuilder(IQuery<DeliveryCarrierServiceAndLocations> query) : base(query)
        {
        }

        public AvailableCarrierServicesOperationQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public AvailableCarrierServicesOperationQueryBuilder Locations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }
    }
}