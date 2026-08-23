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
    public sealed class CollectionSourceInclusionConditionUnknownQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionUnknown, CollectionSourceInclusionConditionUnknownQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionUnknownQueryBuilder Self => this;

        public CollectionSourceInclusionConditionUnknownQueryBuilder() : this("collectionSourceInclusionConditionUnknown")
        {
        }

        public CollectionSourceInclusionConditionUnknownQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionUnknown>(name))
        {
        }

        public CollectionSourceInclusionConditionUnknownQueryBuilder(IQuery<CollectionSourceInclusionConditionUnknown> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionUnknownQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionUnknownQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionUnknownQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionUnknownQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}