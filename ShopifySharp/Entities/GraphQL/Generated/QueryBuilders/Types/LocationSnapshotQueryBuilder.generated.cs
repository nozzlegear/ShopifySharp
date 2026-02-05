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
    public sealed class LocationSnapshotQueryBuilder : FieldsQueryBuilderBase<LocationSnapshot, LocationSnapshotQueryBuilder>
    {
        protected override LocationSnapshotQueryBuilder Self => this;

        public LocationSnapshotQueryBuilder() : this("locationSnapshot")
        {
        }

        public LocationSnapshotQueryBuilder(string name) : base(new Query<LocationSnapshot>(name))
        {
        }

        public LocationSnapshotQueryBuilder(IQuery<LocationSnapshot> query) : base(query)
        {
        }

        public LocationSnapshotQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationAddressQueryBuilder> build)
        {
            var query = new Query<LocationAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationAddress>(query);
            return this;
        }

        public LocationSnapshotQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationSnapshotQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public LocationSnapshotQueryBuilder SnapshottedAt()
        {
            base.InnerQuery.AddField("snapshottedAt");
            return this;
        }
    }
}