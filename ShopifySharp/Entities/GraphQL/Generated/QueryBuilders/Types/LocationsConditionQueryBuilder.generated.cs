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
    public sealed class LocationsConditionQueryBuilder : FieldsQueryBuilderBase<LocationsCondition, LocationsConditionQueryBuilder>
    {
        protected override LocationsConditionQueryBuilder Self => this;

        public LocationsConditionQueryBuilder() : this("locationsCondition")
        {
        }

        public LocationsConditionQueryBuilder(string name) : base(new Query<LocationsCondition>(name))
        {
        }

        public LocationsConditionQueryBuilder(IQuery<LocationsCondition> query) : base(query)
        {
        }

        public LocationsConditionQueryBuilder ApplicationLevel()
        {
            base.InnerQuery.AddField("applicationLevel");
            return this;
        }

        public LocationsConditionQueryBuilder Locations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }
    }
}