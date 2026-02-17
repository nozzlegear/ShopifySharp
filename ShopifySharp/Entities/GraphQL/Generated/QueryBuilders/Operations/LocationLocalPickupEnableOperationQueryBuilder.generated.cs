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
    public sealed class LocationLocalPickupEnableOperationQueryBuilder : FieldsQueryBuilderBase<LocationLocalPickupEnablePayload, LocationLocalPickupEnableOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationLocalPickupEnablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public LocationLocalPickupEnableArgumentsBuilder Arguments { get; }
        protected override LocationLocalPickupEnableOperationQueryBuilder Self => this;

        public LocationLocalPickupEnableOperationQueryBuilder() : this("locationLocalPickupEnable")
        {
        }

        public LocationLocalPickupEnableOperationQueryBuilder(string name) : base(new Query<LocationLocalPickupEnablePayload>(name))
        {
            Arguments = new LocationLocalPickupEnableArgumentsBuilder(base.InnerQuery);
        }

        public LocationLocalPickupEnableOperationQueryBuilder(IQuery<LocationLocalPickupEnablePayload> query) : base(query)
        {
            Arguments = new LocationLocalPickupEnableArgumentsBuilder(base.InnerQuery);
        }

        public LocationLocalPickupEnableOperationQueryBuilder LocalPickupSettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder> build)
        {
            var query = new Query<DeliveryLocalPickupSettings>("localPickupSettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocalPickupSettings>(query);
            return this;
        }

        public LocationLocalPickupEnableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationLocalPickupSettingsError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationLocalPickupSettingsError>(query);
            return this;
        }
    }
}