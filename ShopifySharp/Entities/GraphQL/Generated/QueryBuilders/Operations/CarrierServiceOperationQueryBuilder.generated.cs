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
    public sealed class CarrierServiceOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierService, CarrierServiceOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryCarrierService>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CarrierServiceArgumentsBuilder Arguments { get; }
        protected override CarrierServiceOperationQueryBuilder Self => this;

        public CarrierServiceOperationQueryBuilder() : this("carrierService")
        {
        }

        public CarrierServiceOperationQueryBuilder(string name) : base(new Query<DeliveryCarrierService>(name))
        {
            Arguments = new CarrierServiceArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceOperationQueryBuilder(IQuery<DeliveryCarrierService> query) : base(query)
        {
            Arguments = new CarrierServiceArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceOperationQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public CarrierServiceOperationQueryBuilder AvailableServicesForCountries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryAvailableServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryAvailableService>("availableServicesForCountries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryAvailableServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryAvailableService>(query);
            return this;
        }

        public CarrierServiceOperationQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        public CarrierServiceOperationQueryBuilder FormattedName()
        {
            base.InnerQuery.AddField("formattedName");
            return this;
        }

        public CarrierServiceOperationQueryBuilder Icon(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CarrierServiceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CarrierServiceOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CarrierServiceOperationQueryBuilder SupportsServiceDiscovery()
        {
            base.InnerQuery.AddField("supportsServiceDiscovery");
            return this;
        }
    }
}