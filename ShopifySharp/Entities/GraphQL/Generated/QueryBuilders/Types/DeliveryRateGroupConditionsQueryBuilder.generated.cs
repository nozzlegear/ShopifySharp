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
    public sealed class DeliveryRateGroupConditionsQueryBuilder : FieldsQueryBuilderBase<DeliveryRateGroupConditions, DeliveryRateGroupConditionsQueryBuilder>
    {
        protected override DeliveryRateGroupConditionsQueryBuilder Self => this;

        public DeliveryRateGroupConditionsQueryBuilder() : this("deliveryRateGroupConditions")
        {
        }

        public DeliveryRateGroupConditionsQueryBuilder(string name) : base(new Query<DeliveryRateGroupConditions>(name))
        {
        }

        public DeliveryRateGroupConditionsQueryBuilder(IQuery<DeliveryRateGroupConditions> query) : base(query)
        {
        }

        public DeliveryRateGroupConditionsQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public DeliveryRateGroupConditionsQueryBuilder CollectionsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("collectionsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DeliveryRateGroupConditionsQueryBuilder OriginLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("originLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryRateGroupConditionsQueryBuilder OriginLocationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("originLocationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }
    }
}