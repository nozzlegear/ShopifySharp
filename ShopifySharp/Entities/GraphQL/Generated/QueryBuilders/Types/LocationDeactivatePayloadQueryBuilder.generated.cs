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
    public sealed class LocationDeactivatePayloadQueryBuilder : FieldsQueryBuilderBase<LocationDeactivatePayload, LocationDeactivatePayloadQueryBuilder>
    {
        protected override LocationDeactivatePayloadQueryBuilder Self => this;

        public LocationDeactivatePayloadQueryBuilder() : this("locationDeactivatePayload")
        {
        }

        public LocationDeactivatePayloadQueryBuilder(string name) : base(new Query<LocationDeactivatePayload>(name))
        {
        }

        public LocationDeactivatePayloadQueryBuilder(IQuery<LocationDeactivatePayload> query) : base(query)
        {
        }

        public LocationDeactivatePayloadQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationDeactivatePayloadQueryBuilder LocationDeactivateUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationDeactivateUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationDeactivateUserError>("locationDeactivateUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationDeactivateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationDeactivateUserError>(query);
            return this;
        }
    }
}