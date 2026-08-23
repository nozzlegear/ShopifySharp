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
    public sealed class DeliveryWeightBasedRateQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRate, DeliveryWeightBasedRateQueryBuilder>
    {
        protected override DeliveryWeightBasedRateQueryBuilder Self => this;

        public DeliveryWeightBasedRateQueryBuilder() : this("deliveryWeightBasedRate")
        {
        }

        public DeliveryWeightBasedRateQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRate>(name))
        {
        }

        public DeliveryWeightBasedRateQueryBuilder(IQuery<DeliveryWeightBasedRate> query) : base(query)
        {
        }

        public DeliveryWeightBasedRateQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryWeightBasedRateQueryBuilder MaxWeight(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("maxWeight");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }

        public DeliveryWeightBasedRateQueryBuilder MinWeight(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("minWeight");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }

        public DeliveryWeightBasedRateQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryWeightBasedRateQueryBuilder TransitTimeMaxSeconds()
        {
            base.InnerQuery.AddField("transitTimeMaxSeconds");
            return this;
        }

        public DeliveryWeightBasedRateQueryBuilder TransitTimeMinSeconds()
        {
            base.InnerQuery.AddField("transitTimeMinSeconds");
            return this;
        }
    }
}