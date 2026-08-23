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
    public sealed class DeliveryValueBasedRateQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRate, DeliveryValueBasedRateQueryBuilder>
    {
        protected override DeliveryValueBasedRateQueryBuilder Self => this;

        public DeliveryValueBasedRateQueryBuilder() : this("deliveryValueBasedRate")
        {
        }

        public DeliveryValueBasedRateQueryBuilder(string name) : base(new Query<DeliveryValueBasedRate>(name))
        {
        }

        public DeliveryValueBasedRateQueryBuilder(IQuery<DeliveryValueBasedRate> query) : base(query)
        {
        }

        public DeliveryValueBasedRateQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryValueBasedRateQueryBuilder MaxValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maxValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryValueBasedRateQueryBuilder MinValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("minValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryValueBasedRateQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryValueBasedRateQueryBuilder TransitTimeMaxSeconds()
        {
            base.InnerQuery.AddField("transitTimeMaxSeconds");
            return this;
        }

        public DeliveryValueBasedRateQueryBuilder TransitTimeMinSeconds()
        {
            base.InnerQuery.AddField("transitTimeMinSeconds");
            return this;
        }
    }
}