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
    public sealed class CollectionRuleProductCategoryConditionQueryBuilder : FieldsQueryBuilderBase<CollectionRuleProductCategoryCondition, CollectionRuleProductCategoryConditionQueryBuilder>
    {
        protected override CollectionRuleProductCategoryConditionQueryBuilder Self => this;

        public CollectionRuleProductCategoryConditionQueryBuilder() : this("collectionRuleProductCategoryCondition")
        {
        }

        public CollectionRuleProductCategoryConditionQueryBuilder(string name) : base(new Query<CollectionRuleProductCategoryCondition>(name))
        {
        }

        public CollectionRuleProductCategoryConditionQueryBuilder(IQuery<CollectionRuleProductCategoryCondition> query) : base(query)
        {
        }

        public CollectionRuleProductCategoryConditionQueryBuilder Value(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder> build)
        {
            var query = new Query<ProductTaxonomyNode>("value");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductTaxonomyNode>(query);
            return this;
        }
    }
}