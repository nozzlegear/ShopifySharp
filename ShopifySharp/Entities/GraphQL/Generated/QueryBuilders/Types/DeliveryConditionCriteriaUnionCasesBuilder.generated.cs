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
    public sealed class DeliveryConditionCriteriaUnionCasesBuilder : UnionCasesBuilderBase<DeliveryConditionCriteria, DeliveryConditionCriteriaUnionCasesBuilder>
    {
        protected override DeliveryConditionCriteriaUnionCasesBuilder Self => this;

        public DeliveryConditionCriteriaUnionCasesBuilder(string fieldName = "deliveryConditionCriteria") : this(new Query<DeliveryConditionCriteria>(fieldName))
        {
        }

        public DeliveryConditionCriteriaUnionCasesBuilder(IQuery<DeliveryConditionCriteria> query) : base(query)
        {
        }

        public DeliveryConditionCriteriaUnionCasesBuilder OnMoneyV2(Action<MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("... on MoneyV2");
            var queryBuilder = new MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DeliveryConditionCriteriaUnionCasesBuilder OnWeight(Action<WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("... on Weight");
            var queryBuilder = new WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}