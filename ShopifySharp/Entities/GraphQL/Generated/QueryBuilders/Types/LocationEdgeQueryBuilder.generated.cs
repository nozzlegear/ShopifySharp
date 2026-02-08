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
    public sealed class LocationEdgeQueryBuilder : FieldsQueryBuilderBase<LocationEdge, LocationEdgeQueryBuilder>
    {
        protected override LocationEdgeQueryBuilder Self => this;

        public LocationEdgeQueryBuilder() : this("locationEdge")
        {
        }

        public LocationEdgeQueryBuilder(string name) : base(new Query<LocationEdge>(name))
        {
        }

        public LocationEdgeQueryBuilder(IQuery<LocationEdge> query) : base(query)
        {
        }

        public LocationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public LocationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }
    }
}