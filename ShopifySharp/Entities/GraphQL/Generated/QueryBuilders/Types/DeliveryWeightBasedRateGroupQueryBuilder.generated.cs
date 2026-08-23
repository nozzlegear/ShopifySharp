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
    public sealed class DeliveryWeightBasedRateGroupQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateGroup, DeliveryWeightBasedRateGroupQueryBuilder>
    {
        protected override DeliveryWeightBasedRateGroupQueryBuilder Self => this;

        public DeliveryWeightBasedRateGroupQueryBuilder() : this("deliveryWeightBasedRateGroup")
        {
        }

        public DeliveryWeightBasedRateGroupQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateGroup>(name))
        {
        }

        public DeliveryWeightBasedRateGroupQueryBuilder(IQuery<DeliveryWeightBasedRateGroup> query) : base(query)
        {
        }

        public DeliveryWeightBasedRateGroupQueryBuilder Conditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder> build)
        {
            var query = new Query<DeliveryRateGroupConditions>("conditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryRateGroupConditions>(query);
            return this;
        }

        public DeliveryWeightBasedRateGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryWeightBasedRateGroupQueryBuilder Rates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateConnection>("rates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateConnection>(query);
            return this;
        }
    }
}