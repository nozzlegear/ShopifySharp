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
    public sealed class PickupInStoreLocationQueryBuilder : FieldsQueryBuilderBase<PickupInStoreLocation, PickupInStoreLocationQueryBuilder>
    {
        protected override PickupInStoreLocationQueryBuilder Self => this;

        public PickupInStoreLocationQueryBuilder() : this("pickupInStoreLocation")
        {
        }

        public PickupInStoreLocationQueryBuilder(string name) : base(new Query<PickupInStoreLocation>(name))
        {
        }

        public PickupInStoreLocationQueryBuilder(IQuery<PickupInStoreLocation> query) : base(query)
        {
        }

        public PickupInStoreLocationQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PickupInStoreLocationQueryBuilder DistanceFromBuyer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DistanceQueryBuilder> build)
        {
            var query = new Query<Distance>("distanceFromBuyer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DistanceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Distance>(query);
            return this;
        }

        public PickupInStoreLocationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public PickupInStoreLocationQueryBuilder Instructions()
        {
            base.InnerQuery.AddField("instructions");
            return this;
        }

        public PickupInStoreLocationQueryBuilder LocationId()
        {
            base.InnerQuery.AddField("locationId");
            return this;
        }

        public PickupInStoreLocationQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public PickupInStoreLocationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}