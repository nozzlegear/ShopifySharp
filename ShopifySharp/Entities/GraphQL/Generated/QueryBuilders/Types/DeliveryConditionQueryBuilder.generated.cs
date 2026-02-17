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
    public sealed class DeliveryConditionQueryBuilder : FieldsQueryBuilderBase<DeliveryCondition, DeliveryConditionQueryBuilder>
    {
        protected override DeliveryConditionQueryBuilder Self => this;

        public DeliveryConditionQueryBuilder() : this("deliveryCondition")
        {
        }

        public DeliveryConditionQueryBuilder(string name) : base(new Query<DeliveryCondition>(name))
        {
        }

        public DeliveryConditionQueryBuilder(IQuery<DeliveryCondition> query) : base(query)
        {
        }

        public DeliveryConditionQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DeliveryConditionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryConditionQueryBuilder Operator()
        {
            base.InnerQuery.AddField("operator");
            return this;
        }

        public DeliveryConditionQueryBuilder ConditionCriteria(Action<DeliveryConditionCriteriaUnionCasesBuilder> build)
        {
            var query = new Query<DeliveryConditionCriteria>("conditionCriteria");
            var unionBuilder = new DeliveryConditionCriteriaUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}