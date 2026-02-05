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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CollectionRulesConditionsOperationQueryBuilder : FieldsQueryBuilderBase<CollectionRuleConditions, CollectionRulesConditionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionRuleConditions>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override CollectionRulesConditionsOperationQueryBuilder Self => this;

        public CollectionRulesConditionsOperationQueryBuilder() : this("collectionRulesConditions")
        {
        }

        public CollectionRulesConditionsOperationQueryBuilder(string name) : base(new Query<CollectionRuleConditions>(name))
        {
        }

        public CollectionRulesConditionsOperationQueryBuilder(IQuery<CollectionRuleConditions> query) : base(query)
        {
        }

        public CollectionRulesConditionsOperationQueryBuilder AllowedRelations()
        {
            base.InnerQuery.AddField("allowedRelations");
            return this;
        }

        public CollectionRulesConditionsOperationQueryBuilder DefaultRelation()
        {
            base.InnerQuery.AddField("defaultRelation");
            return this;
        }

        public CollectionRulesConditionsOperationQueryBuilder RuleType()
        {
            base.InnerQuery.AddField("ruleType");
            return this;
        }

        public CollectionRulesConditionsOperationQueryBuilder RuleObject(Action<CollectionRuleConditionsRuleObjectUnionCasesBuilder> build)
        {
            var query = new Query<CollectionRuleConditionsRuleObject>("ruleObject");
            var unionBuilder = new CollectionRuleConditionsRuleObjectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}