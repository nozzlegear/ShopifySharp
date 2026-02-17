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
    public sealed class DeliveryCountryAndZoneQueryBuilder : FieldsQueryBuilderBase<DeliveryCountryAndZone, DeliveryCountryAndZoneQueryBuilder>
    {
        protected override DeliveryCountryAndZoneQueryBuilder Self => this;

        public DeliveryCountryAndZoneQueryBuilder() : this("deliveryCountryAndZone")
        {
        }

        public DeliveryCountryAndZoneQueryBuilder(string name) : base(new Query<DeliveryCountryAndZone>(name))
        {
        }

        public DeliveryCountryAndZoneQueryBuilder(IQuery<DeliveryCountryAndZone> query) : base(query)
        {
        }

        public DeliveryCountryAndZoneQueryBuilder Country(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryQueryBuilder> build)
        {
            var query = new Query<DeliveryCountry>("country");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountry>(query);
            return this;
        }

        public DeliveryCountryAndZoneQueryBuilder Zone()
        {
            base.InnerQuery.AddField("zone");
            return this;
        }
    }
}