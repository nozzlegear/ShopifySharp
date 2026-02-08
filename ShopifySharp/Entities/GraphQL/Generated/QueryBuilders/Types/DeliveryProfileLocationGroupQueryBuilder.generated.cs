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
    public sealed class DeliveryProfileLocationGroupQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileLocationGroup, DeliveryProfileLocationGroupQueryBuilder>
    {
        protected override DeliveryProfileLocationGroupQueryBuilder Self => this;

        public DeliveryProfileLocationGroupQueryBuilder() : this("deliveryProfileLocationGroup")
        {
        }

        public DeliveryProfileLocationGroupQueryBuilder(string name) : base(new Query<DeliveryProfileLocationGroup>(name))
        {
        }

        public DeliveryProfileLocationGroupQueryBuilder(IQuery<DeliveryProfileLocationGroup> query) : base(query)
        {
        }

        public DeliveryProfileLocationGroupQueryBuilder CountriesInAnyZone(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCountryAndZoneQueryBuilder> build)
        {
            var query = new Query<DeliveryCountryAndZone>("countriesInAnyZone");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCountryAndZoneQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountryAndZone>(query);
            return this;
        }

        public DeliveryProfileLocationGroupQueryBuilder LocationGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroup>("locationGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroup>(query);
            return this;
        }

        public DeliveryProfileLocationGroupQueryBuilder LocationGroupZones(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupZoneConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroupZoneConnection>("locationGroupZones");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocationGroupZoneConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroupZoneConnection>(query);
            return this;
        }
    }
}