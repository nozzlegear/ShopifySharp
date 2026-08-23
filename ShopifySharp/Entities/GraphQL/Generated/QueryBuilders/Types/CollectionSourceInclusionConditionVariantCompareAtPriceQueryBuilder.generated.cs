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
    public sealed class CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionVariantCompareAtPrice, CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder Self => this;

        public CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder() : this("collectionSourceInclusionConditionVariantCompareAtPrice")
        {
        }

        public CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionVariantCompareAtPrice>(name))
        {
        }

        public CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder(IQuery<CollectionSourceInclusionConditionVariantCompareAtPrice> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder Value(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("value");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}