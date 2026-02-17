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
    public sealed class CollectionRuleQueryBuilder : FieldsQueryBuilderBase<CollectionRule, CollectionRuleQueryBuilder>
    {
        protected override CollectionRuleQueryBuilder Self => this;

        public CollectionRuleQueryBuilder() : this("collectionRule")
        {
        }

        public CollectionRuleQueryBuilder(string name) : base(new Query<CollectionRule>(name))
        {
        }

        public CollectionRuleQueryBuilder(IQuery<CollectionRule> query) : base(query)
        {
        }

        public CollectionRuleQueryBuilder Column()
        {
            base.InnerQuery.AddField("column");
            return this;
        }

        public CollectionRuleQueryBuilder Condition()
        {
            base.InnerQuery.AddField("condition");
            return this;
        }

        public CollectionRuleQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionRuleQueryBuilder ConditionObject(Action<CollectionRuleConditionObjectUnionCasesBuilder> build)
        {
            var query = new Query<CollectionRuleConditionObject>("conditionObject");
            var unionBuilder = new CollectionRuleConditionObjectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}