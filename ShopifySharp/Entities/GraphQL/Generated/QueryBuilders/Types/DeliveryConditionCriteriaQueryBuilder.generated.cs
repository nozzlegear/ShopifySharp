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
    public sealed class DeliveryConditionCriteriaQueryBuilder : FieldsQueryBuilderBase<DeliveryConditionCriteria, DeliveryConditionCriteriaQueryBuilder>
    {
        protected override DeliveryConditionCriteriaQueryBuilder Self => this;

        public DeliveryConditionCriteriaQueryBuilder() : this("deliveryConditionCriteria")
        {
        }

        public DeliveryConditionCriteriaQueryBuilder(string name) : base(new Query<DeliveryConditionCriteria>(name))
        {
        }

        public DeliveryConditionCriteriaQueryBuilder(IQuery<DeliveryConditionCriteria> query) : base(query)
        {
        }

        public DeliveryConditionCriteriaQueryBuilder DeliveryConditionCriteria(Action<DeliveryConditionCriteriaUnionCasesBuilder> build)
        {
            var query = new Query<DeliveryConditionCriteria>("deliveryConditionCriteria");
            var unionBuilder = new DeliveryConditionCriteriaUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}