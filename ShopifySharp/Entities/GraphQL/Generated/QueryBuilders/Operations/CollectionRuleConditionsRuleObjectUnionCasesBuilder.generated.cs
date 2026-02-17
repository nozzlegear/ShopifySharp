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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CollectionRuleConditionsRuleObjectUnionCasesBuilder : UnionCasesBuilderBase<CollectionRuleConditionsRuleObject, CollectionRuleConditionsRuleObjectUnionCasesBuilder>
    {
        protected override CollectionRuleConditionsRuleObjectUnionCasesBuilder Self => this;

        public CollectionRuleConditionsRuleObjectUnionCasesBuilder(string fieldName = "ruleObject") : this(new Query<CollectionRuleConditionsRuleObject>(fieldName))
        {
        }

        public CollectionRuleConditionsRuleObjectUnionCasesBuilder(IQuery<CollectionRuleConditionsRuleObject> query) : base(query)
        {
        }

        public CollectionRuleConditionsRuleObjectUnionCasesBuilder OnCollectionRuleMetafieldCondition(Action<CollectionRuleMetafieldConditionQueryBuilder> build)
        {
            var query = new Query<CollectionRuleMetafieldCondition>("... on CollectionRuleMetafieldCondition");
            var queryBuilder = new CollectionRuleMetafieldConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}