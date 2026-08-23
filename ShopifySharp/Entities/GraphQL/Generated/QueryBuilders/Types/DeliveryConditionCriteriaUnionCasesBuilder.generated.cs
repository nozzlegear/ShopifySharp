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
    public sealed class DeliveryConditionCriteriaUnionCasesBuilder : UnionCasesBuilderBase<DeliveryConditionCriteria, DeliveryConditionCriteriaUnionCasesBuilder>
    {
        protected override DeliveryConditionCriteriaUnionCasesBuilder Self => this;

        public DeliveryConditionCriteriaUnionCasesBuilder(string fieldName = "deliveryConditionCriteria") : this(new Query<DeliveryConditionCriteria>(fieldName))
        {
        }

        public DeliveryConditionCriteriaUnionCasesBuilder(IQuery<DeliveryConditionCriteria> query) : base(query)
        {
        }

        public DeliveryConditionCriteriaUnionCasesBuilder OnMoneyV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("... on MoneyV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DeliveryConditionCriteriaUnionCasesBuilder OnWeight(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("... on Weight");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}