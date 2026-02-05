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
    public sealed class LocationLocalPickupDisablePayloadQueryBuilder : FieldsQueryBuilderBase<LocationLocalPickupDisablePayload, LocationLocalPickupDisablePayloadQueryBuilder>
    {
        protected override LocationLocalPickupDisablePayloadQueryBuilder Self => this;

        public LocationLocalPickupDisablePayloadQueryBuilder() : this("locationLocalPickupDisablePayload")
        {
        }

        public LocationLocalPickupDisablePayloadQueryBuilder(string name) : base(new Query<LocationLocalPickupDisablePayload>(name))
        {
        }

        public LocationLocalPickupDisablePayloadQueryBuilder(IQuery<LocationLocalPickupDisablePayload> query) : base(query)
        {
        }

        public LocationLocalPickupDisablePayloadQueryBuilder LocationId()
        {
            base.InnerQuery.AddField("locationId");
            return this;
        }

        public LocationLocalPickupDisablePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationLocalPickupSettingsError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationLocalPickupSettingsErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationLocalPickupSettingsError>(query);
            return this;
        }
    }
}