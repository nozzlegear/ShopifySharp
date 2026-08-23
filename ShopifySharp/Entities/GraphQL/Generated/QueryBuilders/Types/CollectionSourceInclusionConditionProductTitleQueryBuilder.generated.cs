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
    public sealed class CollectionSourceInclusionConditionProductTitleQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionProductTitle, CollectionSourceInclusionConditionProductTitleQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionProductTitleQueryBuilder Self => this;

        public CollectionSourceInclusionConditionProductTitleQueryBuilder() : this("collectionSourceInclusionConditionProductTitle")
        {
        }

        public CollectionSourceInclusionConditionProductTitleQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionProductTitle>(name))
        {
        }

        public CollectionSourceInclusionConditionProductTitleQueryBuilder(IQuery<CollectionSourceInclusionConditionProductTitle> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionProductTitleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionProductTitleQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionProductTitleQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionProductTitleQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}