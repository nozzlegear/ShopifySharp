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
    public sealed class DeliveryCarrierServiceAndLocationsQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierServiceAndLocations, DeliveryCarrierServiceAndLocationsQueryBuilder>
    {
        protected override DeliveryCarrierServiceAndLocationsQueryBuilder Self => this;

        public DeliveryCarrierServiceAndLocationsQueryBuilder() : this("deliveryCarrierServiceAndLocations")
        {
        }

        public DeliveryCarrierServiceAndLocationsQueryBuilder(string name) : base(new Query<DeliveryCarrierServiceAndLocations>(name))
        {
        }

        public DeliveryCarrierServiceAndLocationsQueryBuilder(IQuery<DeliveryCarrierServiceAndLocations> query) : base(query)
        {
        }

        public DeliveryCarrierServiceAndLocationsQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public DeliveryCarrierServiceAndLocationsQueryBuilder Locations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }
    }
}