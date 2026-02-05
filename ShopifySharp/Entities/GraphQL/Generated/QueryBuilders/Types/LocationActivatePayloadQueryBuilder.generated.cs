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
    public sealed class LocationActivatePayloadQueryBuilder : FieldsQueryBuilderBase<LocationActivatePayload, LocationActivatePayloadQueryBuilder>
    {
        protected override LocationActivatePayloadQueryBuilder Self => this;

        public LocationActivatePayloadQueryBuilder() : this("locationActivatePayload")
        {
        }

        public LocationActivatePayloadQueryBuilder(string name) : base(new Query<LocationActivatePayload>(name))
        {
        }

        public LocationActivatePayloadQueryBuilder(IQuery<LocationActivatePayload> query) : base(query)
        {
        }

        public LocationActivatePayloadQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationActivatePayloadQueryBuilder LocationActivateUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationActivateUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationActivateUserError>("locationActivateUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationActivateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationActivateUserError>(query);
            return this;
        }
    }
}