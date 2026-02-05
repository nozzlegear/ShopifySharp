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
    public sealed class DeliveryProfileQueryBuilder : FieldsQueryBuilderBase<DeliveryProfile, DeliveryProfileQueryBuilder>
    {
        protected override DeliveryProfileQueryBuilder Self => this;

        public DeliveryProfileQueryBuilder() : this("deliveryProfile")
        {
        }

        public DeliveryProfileQueryBuilder(string name) : base(new Query<DeliveryProfile>(name))
        {
        }

        public DeliveryProfileQueryBuilder(IQuery<DeliveryProfile> query) : base(query)
        {
        }

        public DeliveryProfileQueryBuilder ActiveMethodDefinitionsCount()
        {
            base.InnerQuery.AddField("activeMethodDefinitionsCount");
            return this;
        }

        public DeliveryProfileQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public DeliveryProfileQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Legacy mode profiles are no longer supported. This will be removed in 2026-04.")]
        public DeliveryProfileQueryBuilder LegacyMode()
        {
            base.InnerQuery.AddField("legacyMode");
            return this;
        }

        public DeliveryProfileQueryBuilder LocationsWithoutRatesCount()
        {
            base.InnerQuery.AddField("locationsWithoutRatesCount");
            return this;
        }

        public DeliveryProfileQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryProfileQueryBuilder OriginLocationCount()
        {
            base.InnerQuery.AddField("originLocationCount");
            return this;
        }

        public DeliveryProfileQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder ProductVariantsCountV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProductVariantsCountQueryBuilder> build)
        {
            var query = new Query<DeliveryProductVariantsCount>("productVariantsCountV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProductVariantsCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProductVariantsCount>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder ProfileItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItemConnection>("profileItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItemConnection>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder ProfileLocationGroups(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileLocationGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileLocationGroup>("profileLocationGroups");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileLocationGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileLocationGroup>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder UnassignedLocations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("unassignedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder UnassignedLocationsPaginated(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("unassignedLocationsPaginated");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryProfileQueryBuilder Version()
        {
            base.InnerQuery.AddField("version");
            return this;
        }

        public DeliveryProfileQueryBuilder ZoneCountryCount()
        {
            base.InnerQuery.AddField("zoneCountryCount");
            return this;
        }
    }
}