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
    public sealed class CollectionRuleConditionsQueryBuilder : FieldsQueryBuilderBase<CollectionRuleConditions, CollectionRuleConditionsQueryBuilder>
    {
        protected override CollectionRuleConditionsQueryBuilder Self => this;

        public CollectionRuleConditionsQueryBuilder() : this("collectionRuleConditions")
        {
        }

        public CollectionRuleConditionsQueryBuilder(string name) : base(new Query<CollectionRuleConditions>(name))
        {
        }

        public CollectionRuleConditionsQueryBuilder(IQuery<CollectionRuleConditions> query) : base(query)
        {
        }

        public CollectionRuleConditionsQueryBuilder AllowedRelations()
        {
            base.InnerQuery.AddField("allowedRelations");
            return this;
        }

        public CollectionRuleConditionsQueryBuilder DefaultRelation()
        {
            base.InnerQuery.AddField("defaultRelation");
            return this;
        }

        public CollectionRuleConditionsQueryBuilder RuleType()
        {
            base.InnerQuery.AddField("ruleType");
            return this;
        }

        public CollectionRuleConditionsQueryBuilder RuleObject(Action<CollectionRuleConditionsRuleObjectUnionCasesBuilder> build)
        {
            var query = new Query<CollectionRuleConditionsRuleObject>("ruleObject");
            var unionBuilder = new CollectionRuleConditionsRuleObjectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}