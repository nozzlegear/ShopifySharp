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
    public sealed class DeliveryFlatRateGroupQueryBuilder : FieldsQueryBuilderBase<DeliveryFlatRateGroup, DeliveryFlatRateGroupQueryBuilder>
    {
        protected override DeliveryFlatRateGroupQueryBuilder Self => this;

        public DeliveryFlatRateGroupQueryBuilder() : this("deliveryFlatRateGroup")
        {
        }

        public DeliveryFlatRateGroupQueryBuilder(string name) : base(new Query<DeliveryFlatRateGroup>(name))
        {
        }

        public DeliveryFlatRateGroupQueryBuilder(IQuery<DeliveryFlatRateGroup> query) : base(query)
        {
        }

        public DeliveryFlatRateGroupQueryBuilder Conditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder> build)
        {
            var query = new Query<DeliveryRateGroupConditions>("conditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryRateGroupConditions>(query);
            return this;
        }

        public DeliveryFlatRateGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryFlatRateGroupQueryBuilder Rate(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRate>("rate");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRate>(query);
            return this;
        }
    }
}