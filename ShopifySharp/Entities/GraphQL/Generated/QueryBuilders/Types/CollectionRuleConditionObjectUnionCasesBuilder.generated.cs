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
    public sealed class CollectionRuleConditionObjectUnionCasesBuilder : UnionCasesBuilderBase<CollectionRuleConditionObject, CollectionRuleConditionObjectUnionCasesBuilder>
    {
        protected override CollectionRuleConditionObjectUnionCasesBuilder Self => this;

        public CollectionRuleConditionObjectUnionCasesBuilder(string fieldName = "collectionRuleConditionObject") : this(new Query<CollectionRuleConditionObject>(fieldName))
        {
        }

        public CollectionRuleConditionObjectUnionCasesBuilder(IQuery<CollectionRuleConditionObject> query) : base(query)
        {
        }

        public CollectionRuleConditionObjectUnionCasesBuilder OnCollectionRuleCategoryCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleCategoryConditionQueryBuilder> build)
        {
            var query = new Query<CollectionRuleCategoryCondition>("... on CollectionRuleCategoryCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleCategoryConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionRuleConditionObjectUnionCasesBuilder OnCollectionRuleMetafieldCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleMetafieldConditionQueryBuilder> build)
        {
            var query = new Query<CollectionRuleMetafieldCondition>("... on CollectionRuleMetafieldCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleMetafieldConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionRuleConditionObjectUnionCasesBuilder OnCollectionRuleProductCategoryCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleProductCategoryConditionQueryBuilder> build)
        {
            var query = new Query<CollectionRuleProductCategoryCondition>("... on CollectionRuleProductCategoryCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleProductCategoryConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionRuleConditionObjectUnionCasesBuilder OnCollectionRuleTextCondition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleTextConditionQueryBuilder> build)
        {
            var query = new Query<CollectionRuleTextCondition>("... on CollectionRuleTextCondition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionRuleTextConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}