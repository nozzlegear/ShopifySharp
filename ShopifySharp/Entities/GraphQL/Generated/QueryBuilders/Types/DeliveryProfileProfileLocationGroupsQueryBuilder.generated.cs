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
    public sealed class DeliveryProfileProfileLocationGroupsQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileLocationGroup, DeliveryProfileProfileLocationGroupsQueryBuilder>, IHasArguments<DeliveryProfileProfileLocationGroupsArgumentsBuilder>
    {
        public DeliveryProfileProfileLocationGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileProfileLocationGroupsQueryBuilder Self => this;

        public DeliveryProfileProfileLocationGroupsQueryBuilder(string name) : base(new Query<DeliveryProfileLocationGroup>(name))
        {
            Arguments = new DeliveryProfileProfileLocationGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileProfileLocationGroupsQueryBuilder(IQuery<DeliveryProfileLocationGroup> query) : base(query)
        {
            Arguments = new DeliveryProfileProfileLocationGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileProfileLocationGroupsQueryBuilder SetArguments(Action<DeliveryProfileProfileLocationGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryProfileProfileLocationGroupsQueryBuilder CountriesInAnyZone(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryAndZoneQueryBuilder> build)
        {
            var query = new Query<DeliveryCountryAndZone>("countriesInAnyZone");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryAndZoneQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountryAndZone>(query);
            return this;
        }

        public DeliveryProfileProfileLocationGroupsQueryBuilder LocationGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroup>("locationGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroup>(query);
            return this;
        }

        public DeliveryProfileProfileLocationGroupsQueryBuilder LocationGroupZones(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupZoneConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryLocationGroupZoneConnection>("locationGroupZones");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocationGroupZoneConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocationGroupZoneConnection>(query);
            return this;
        }
    }
}