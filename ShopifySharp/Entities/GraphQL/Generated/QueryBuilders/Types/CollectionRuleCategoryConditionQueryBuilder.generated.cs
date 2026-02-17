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
    public sealed class CollectionRuleCategoryConditionQueryBuilder : FieldsQueryBuilderBase<CollectionRuleCategoryCondition, CollectionRuleCategoryConditionQueryBuilder>
    {
        protected override CollectionRuleCategoryConditionQueryBuilder Self => this;

        public CollectionRuleCategoryConditionQueryBuilder() : this("collectionRuleCategoryCondition")
        {
        }

        public CollectionRuleCategoryConditionQueryBuilder(string name) : base(new Query<CollectionRuleCategoryCondition>(name))
        {
        }

        public CollectionRuleCategoryConditionQueryBuilder(IQuery<CollectionRuleCategoryCondition> query) : base(query)
        {
        }

        public CollectionRuleCategoryConditionQueryBuilder Value(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("value");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }
    }
}