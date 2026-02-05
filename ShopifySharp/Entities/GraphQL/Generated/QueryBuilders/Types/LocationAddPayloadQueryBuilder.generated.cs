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
    public sealed class LocationAddPayloadQueryBuilder : FieldsQueryBuilderBase<LocationAddPayload, LocationAddPayloadQueryBuilder>
    {
        protected override LocationAddPayloadQueryBuilder Self => this;

        public LocationAddPayloadQueryBuilder() : this("locationAddPayload")
        {
        }

        public LocationAddPayloadQueryBuilder(string name) : base(new Query<LocationAddPayload>(name))
        {
        }

        public LocationAddPayloadQueryBuilder(IQuery<LocationAddPayload> query) : base(query)
        {
        }

        public LocationAddPayloadQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationAddPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationAddUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationAddUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationAddUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationAddUserError>(query);
            return this;
        }
    }
}