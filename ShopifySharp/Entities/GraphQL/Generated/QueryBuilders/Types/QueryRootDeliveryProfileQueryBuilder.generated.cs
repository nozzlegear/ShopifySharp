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
    public sealed class QueryRootDeliveryProfileQueryBuilder : FieldsQueryBuilderBase<DeliveryProfile, QueryRootDeliveryProfileQueryBuilder>, IHasArguments<QueryRootDeliveryProfileArgumentsBuilder>
    {
        public QueryRootDeliveryProfileArgumentsBuilder Arguments { get; }
        protected override QueryRootDeliveryProfileQueryBuilder Self => this;

        public QueryRootDeliveryProfileQueryBuilder(string name) : base(new Query<DeliveryProfile>(name))
        {
            Arguments = new QueryRootDeliveryProfileArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryProfileQueryBuilder(IQuery<DeliveryProfile> query) : base(query)
        {
            Arguments = new QueryRootDeliveryProfileArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryProfileQueryBuilder SetArguments(Action<QueryRootDeliveryProfileArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder ActiveMethodDefinitionsCount()
        {
            base.InnerQuery.AddField("activeMethodDefinitionsCount");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder LegacyMode()
        {
            base.InnerQuery.AddField("legacyMode");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder LocationsWithoutRatesCount()
        {
            base.InnerQuery.AddField("locationsWithoutRatesCount");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder OriginLocationCount()
        {
            base.InnerQuery.AddField("originLocationCount");
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder ProductVariantsCountV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProductVariantsCountQueryBuilder> build)
        {
            var query = new Query<DeliveryProductVariantsCount>("productVariantsCountV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProductVariantsCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProductVariantsCount>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder ProfileItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItemConnection>("profileItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItemConnection>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder ProfileLocationGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileLocationGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileLocationGroup>("profileLocationGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileLocationGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileLocationGroup>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder UnassignedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("unassignedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder UnassignedLocationsPaginated(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("unassignedLocationsPaginated");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public QueryRootDeliveryProfileQueryBuilder ZoneCountryCount()
        {
            base.InnerQuery.AddField("zoneCountryCount");
            return this;
        }
    }
}