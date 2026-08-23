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
    public sealed class DeliveryValueBasedRateGroupQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRateGroup, DeliveryValueBasedRateGroupQueryBuilder>
    {
        protected override DeliveryValueBasedRateGroupQueryBuilder Self => this;

        public DeliveryValueBasedRateGroupQueryBuilder() : this("deliveryValueBasedRateGroup")
        {
        }

        public DeliveryValueBasedRateGroupQueryBuilder(string name) : base(new Query<DeliveryValueBasedRateGroup>(name))
        {
        }

        public DeliveryValueBasedRateGroupQueryBuilder(IQuery<DeliveryValueBasedRateGroup> query) : base(query)
        {
        }

        public DeliveryValueBasedRateGroupQueryBuilder Conditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder> build)
        {
            var query = new Query<DeliveryRateGroupConditions>("conditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryRateGroupConditions>(query);
            return this;
        }

        public DeliveryValueBasedRateGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryValueBasedRateGroupQueryBuilder Rates(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateConnectionQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateConnection>("rates");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateConnection>(query);
            return this;
        }
    }
}