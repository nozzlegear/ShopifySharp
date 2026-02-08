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
    public sealed class DeliveryZoneQueryBuilder : FieldsQueryBuilderBase<DeliveryZone, DeliveryZoneQueryBuilder>
    {
        protected override DeliveryZoneQueryBuilder Self => this;

        public DeliveryZoneQueryBuilder() : this("deliveryZone")
        {
        }

        public DeliveryZoneQueryBuilder(string name) : base(new Query<DeliveryZone>(name))
        {
        }

        public DeliveryZoneQueryBuilder(IQuery<DeliveryZone> query) : base(query)
        {
        }

        public DeliveryZoneQueryBuilder Countries(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCountryQueryBuilder> build)
        {
            var query = new Query<DeliveryCountry>("countries");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCountryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountry>(query);
            return this;
        }

        public DeliveryZoneQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryZoneQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}