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
    public sealed class LocationEditPayloadQueryBuilder : FieldsQueryBuilderBase<LocationEditPayload, LocationEditPayloadQueryBuilder>
    {
        protected override LocationEditPayloadQueryBuilder Self => this;

        public LocationEditPayloadQueryBuilder() : this("locationEditPayload")
        {
        }

        public LocationEditPayloadQueryBuilder(string name) : base(new Query<LocationEditPayload>(name))
        {
        }

        public LocationEditPayloadQueryBuilder(IQuery<LocationEditPayload> query) : base(query)
        {
        }

        public LocationEditPayloadQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationEditPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationEditUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationEditUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationEditUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationEditUserError>(query);
            return this;
        }
    }
}