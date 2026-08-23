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
    public sealed class CollectionSourceInclusionConditionVariantWeightQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionVariantWeight, CollectionSourceInclusionConditionVariantWeightQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionVariantWeightQueryBuilder Self => this;

        public CollectionSourceInclusionConditionVariantWeightQueryBuilder() : this("collectionSourceInclusionConditionVariantWeight")
        {
        }

        public CollectionSourceInclusionConditionVariantWeightQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionVariantWeight>(name))
        {
        }

        public CollectionSourceInclusionConditionVariantWeightQueryBuilder(IQuery<CollectionSourceInclusionConditionVariantWeight> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionVariantWeightQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionVariantWeightQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionVariantWeightQueryBuilder Value(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder> build)
        {
            var query = new Query<Weight>("value");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Weight>(query);
            return this;
        }
    }
}