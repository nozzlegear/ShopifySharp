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
    public sealed class CollectionSourceExclusionConditionProductCategoryValueQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionProductCategoryValue, CollectionSourceExclusionConditionProductCategoryValueQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionProductCategoryValueQueryBuilder Self => this;

        public CollectionSourceExclusionConditionProductCategoryValueQueryBuilder() : this("collectionSourceExclusionConditionProductCategoryValue")
        {
        }

        public CollectionSourceExclusionConditionProductCategoryValueQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionProductCategoryValue>(name))
        {
        }

        public CollectionSourceExclusionConditionProductCategoryValueQueryBuilder(IQuery<CollectionSourceExclusionConditionProductCategoryValue> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionProductCategoryValueQueryBuilder Category(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("category");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        public CollectionSourceExclusionConditionProductCategoryValueQueryBuilder IncludeDescendants()
        {
            base.InnerQuery.AddField("includeDescendants");
            return this;
        }
    }
}