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
    public sealed class CollectionSourceExclusionConditionProductTagQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionProductTag, CollectionSourceExclusionConditionProductTagQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionProductTagQueryBuilder Self => this;

        public CollectionSourceExclusionConditionProductTagQueryBuilder() : this("collectionSourceExclusionConditionProductTag")
        {
        }

        public CollectionSourceExclusionConditionProductTagQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionProductTag>(name))
        {
        }

        public CollectionSourceExclusionConditionProductTagQueryBuilder(IQuery<CollectionSourceExclusionConditionProductTag> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionProductTagQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionProductTagQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionConditionProductTagQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceExclusionConditionProductTagQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}