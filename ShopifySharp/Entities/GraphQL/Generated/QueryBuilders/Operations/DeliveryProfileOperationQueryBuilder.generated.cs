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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DeliveryProfileOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryProfile, DeliveryProfileOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryProfile>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DeliveryProfileArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileOperationQueryBuilder Self => this;

        public DeliveryProfileOperationQueryBuilder() : this("deliveryProfile")
        {
        }

        public DeliveryProfileOperationQueryBuilder(string name) : base(new Query<DeliveryProfile>(name))
        {
            Arguments = new DeliveryProfileArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileOperationQueryBuilder(IQuery<DeliveryProfile> query) : base(query)
        {
            Arguments = new DeliveryProfileArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileOperationQueryBuilder ActiveMethodDefinitionsCount()
        {
            base.InnerQuery.AddField("activeMethodDefinitionsCount");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder Default()
        {
            base.InnerQuery.AddField("default");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        [Obsolete("Legacy mode profiles are no longer supported. This will be removed in 2026-04.")]
        public DeliveryProfileOperationQueryBuilder LegacyMode()
        {
            base.InnerQuery.AddField("legacyMode");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder LocationsWithoutRatesCount()
        {
            base.InnerQuery.AddField("locationsWithoutRatesCount");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder OriginLocationCount()
        {
            base.InnerQuery.AddField("originLocationCount");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder ProductVariantsCountV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProductVariantsCountQueryBuilder> build)
        {
            var query = new Query<DeliveryProductVariantsCount>("productVariantsCountV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProductVariantsCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProductVariantsCount>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder ProfileItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItemConnection>("profileItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItemConnection>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder ProfileLocationGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileLocationGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileLocationGroup>("profileLocationGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileLocationGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileLocationGroup>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder UnassignedLocations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("unassignedLocations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder UnassignedLocationsPaginated(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder> build)
        {
            var query = new Query<LocationConnection>("unassignedLocationsPaginated");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationConnection>(query);
            return this;
        }

        public DeliveryProfileOperationQueryBuilder Version()
        {
            base.InnerQuery.AddField("version");
            return this;
        }

        public DeliveryProfileOperationQueryBuilder ZoneCountryCount()
        {
            base.InnerQuery.AddField("zoneCountryCount");
            return this;
        }
    }
}