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
    public sealed class CollectionSourceInclusionConditionVariantTitleQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionVariantTitle, CollectionSourceInclusionConditionVariantTitleQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionVariantTitleQueryBuilder Self => this;

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder() : this("collectionSourceInclusionConditionVariantTitle")
        {
        }

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionVariantTitle>(name))
        {
        }

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder(IQuery<CollectionSourceInclusionConditionVariantTitle> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionVariantTitleQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}