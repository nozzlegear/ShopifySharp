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
    public sealed class CollectionSourceInclusionConditionProductTagQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionProductTag, CollectionSourceInclusionConditionProductTagQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionProductTagQueryBuilder Self => this;

        public CollectionSourceInclusionConditionProductTagQueryBuilder() : this("collectionSourceInclusionConditionProductTag")
        {
        }

        public CollectionSourceInclusionConditionProductTagQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionProductTag>(name))
        {
        }

        public CollectionSourceInclusionConditionProductTagQueryBuilder(IQuery<CollectionSourceInclusionConditionProductTag> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionProductTagQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionProductTagQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionProductTagQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionProductTagQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}