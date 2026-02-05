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
    public sealed class LocationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<LocationDeletePayload, LocationDeletePayloadQueryBuilder>
    {
        protected override LocationDeletePayloadQueryBuilder Self => this;

        public LocationDeletePayloadQueryBuilder() : this("locationDeletePayload")
        {
        }

        public LocationDeletePayloadQueryBuilder(string name) : base(new Query<LocationDeletePayload>(name))
        {
        }

        public LocationDeletePayloadQueryBuilder(IQuery<LocationDeletePayload> query) : base(query)
        {
        }

        public LocationDeletePayloadQueryBuilder DeletedLocationId()
        {
            base.InnerQuery.AddField("deletedLocationId");
            return this;
        }

        public LocationDeletePayloadQueryBuilder LocationDeleteUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationDeleteUserError>("locationDeleteUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationDeleteUserError>(query);
            return this;
        }
    }
}