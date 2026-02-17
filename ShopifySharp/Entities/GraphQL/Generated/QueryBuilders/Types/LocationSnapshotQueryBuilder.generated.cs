#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
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

        public LocationSnapshotQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationAddressQueryBuilder> build)
        {
            var query = new Query<LocationAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationAddress>(query);
            return this;
        }

        public LocationSnapshotQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
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