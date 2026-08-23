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
    public sealed class CollectionSourceInclusionConditionProductCategoryQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionProductCategory, CollectionSourceInclusionConditionProductCategoryQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionProductCategoryQueryBuilder Self => this;

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder() : this("collectionSourceInclusionConditionProductCategory")
        {
        }

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionProductCategory>(name))
        {
        }

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder(IQuery<CollectionSourceInclusionConditionProductCategory> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionProductCategoryQueryBuilder Values(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductCategoryValueQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductCategoryValue>("values");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductCategoryValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionSourceInclusionConditionProductCategoryValue>(query);
            return this;
        }
    }
}