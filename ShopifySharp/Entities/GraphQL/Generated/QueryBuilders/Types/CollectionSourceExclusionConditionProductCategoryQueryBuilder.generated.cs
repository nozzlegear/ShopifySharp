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
    public sealed class CollectionSourceExclusionConditionProductCategoryQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionProductCategory, CollectionSourceExclusionConditionProductCategoryQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionProductCategoryQueryBuilder Self => this;

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder() : this("collectionSourceExclusionConditionProductCategory")
        {
        }

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionProductCategory>(name))
        {
        }

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder(IQuery<CollectionSourceExclusionConditionProductCategory> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceExclusionConditionProductCategoryQueryBuilder Values(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductCategoryValueQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductCategoryValue>("values");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductCategoryValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionSourceExclusionConditionProductCategoryValue>(query);
            return this;
        }
    }
}