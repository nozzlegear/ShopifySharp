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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class LocationLocalPickupEnablePayloadQueryBuilder : FieldsQueryBuilderBase<LocationLocalPickupEnablePayload, LocationLocalPickupEnablePayloadQueryBuilder>
    {
        protected override LocationLocalPickupEnablePayloadQueryBuilder Self => this;

        public LocationLocalPickupEnablePayloadQueryBuilder() : this("locationLocalPickupEnablePayload")
        {
        }

        public LocationLocalPickupEnablePayloadQueryBuilder(string name) : base(new Query<LocationLocalPickupEnablePayload>(name))
        {
        }

        public LocationLocalPickupEnablePayloadQueryBuilder(IQuery<LocationLocalPickupEnablePayload> query) : base(query)
        {
        }

        public LocationLocalPickupEnablePayloadQueryBuilder LocalPickupSettings(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder> build)
        {
            var query = new Query<DeliveryLocalPickupSettings>("localPickupSettings");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocalPickupSettings>(query);
            return this;
        }

        public LocationLocalPickupEnablePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationLocalPickupSettingsError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationLocalPickupSettingsError>(query);
            return this;
        }
    }
}