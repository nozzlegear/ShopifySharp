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
    public sealed class CollectionSourceExclusionConditionUnknownQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionUnknown, CollectionSourceExclusionConditionUnknownQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionUnknownQueryBuilder Self => this;

        public CollectionSourceExclusionConditionUnknownQueryBuilder() : this("collectionSourceExclusionConditionUnknown")
        {
        }

        public CollectionSourceExclusionConditionUnknownQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionUnknown>(name))
        {
        }

        public CollectionSourceExclusionConditionUnknownQueryBuilder(IQuery<CollectionSourceExclusionConditionUnknown> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionUnknownQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionUnknownQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionConditionUnknownQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceExclusionConditionUnknownQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}