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
    public sealed class DeliveryFlatRateQueryBuilder : FieldsQueryBuilderBase<DeliveryFlatRate, DeliveryFlatRateQueryBuilder>
    {
        protected override DeliveryFlatRateQueryBuilder Self => this;

        public DeliveryFlatRateQueryBuilder() : this("deliveryFlatRate")
        {
        }

        public DeliveryFlatRateQueryBuilder(string name) : base(new Query<DeliveryFlatRate>(name))
        {
        }

        public DeliveryFlatRateQueryBuilder(IQuery<DeliveryFlatRate> query) : base(query)
        {
        }

        public DeliveryFlatRateQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryFlatRateQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryFlatRateQueryBuilder TransitTimeMaxSeconds()
        {
            base.InnerQuery.AddField("transitTimeMaxSeconds");
            return this;
        }

        public DeliveryFlatRateQueryBuilder TransitTimeMinSeconds()
        {
            base.InnerQuery.AddField("transitTimeMinSeconds");
            return this;
        }
    }
}