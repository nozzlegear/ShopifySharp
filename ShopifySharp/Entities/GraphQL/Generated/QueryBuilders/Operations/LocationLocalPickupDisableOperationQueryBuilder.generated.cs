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
    public sealed class LocationLocalPickupDisableOperationQueryBuilder : FieldsQueryBuilderBase<LocationLocalPickupDisablePayload, LocationLocalPickupDisableOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationLocalPickupDisablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public LocationLocalPickupDisableArgumentsBuilder Arguments { get; }
        protected override LocationLocalPickupDisableOperationQueryBuilder Self => this;

        public LocationLocalPickupDisableOperationQueryBuilder() : this("locationLocalPickupDisable")
        {
        }

        public LocationLocalPickupDisableOperationQueryBuilder(string name) : base(new Query<LocationLocalPickupDisablePayload>(name))
        {
            Arguments = new LocationLocalPickupDisableArgumentsBuilder(base.InnerQuery);
        }

        public LocationLocalPickupDisableOperationQueryBuilder(IQuery<LocationLocalPickupDisablePayload> query) : base(query)
        {
            Arguments = new LocationLocalPickupDisableArgumentsBuilder(base.InnerQuery);
        }

        public LocationLocalPickupDisableOperationQueryBuilder LocationId()
        {
            base.InnerQuery.AddField("locationId");
            return this;
        }

        public LocationLocalPickupDisableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationLocalPickupSettingsError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationLocalPickupSettingsError>(query);
            return this;
        }
    }
}