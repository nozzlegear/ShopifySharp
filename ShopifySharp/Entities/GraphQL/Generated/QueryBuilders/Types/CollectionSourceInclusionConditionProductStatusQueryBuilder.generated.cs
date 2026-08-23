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
    public sealed class CollectionSourceInclusionConditionProductStatusQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionProductStatus, CollectionSourceInclusionConditionProductStatusQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionProductStatusQueryBuilder Self => this;

        public CollectionSourceInclusionConditionProductStatusQueryBuilder() : this("collectionSourceInclusionConditionProductStatus")
        {
        }

        public CollectionSourceInclusionConditionProductStatusQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionProductStatus>(name))
        {
        }

        public CollectionSourceInclusionConditionProductStatusQueryBuilder(IQuery<CollectionSourceInclusionConditionProductStatus> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionProductStatusQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionProductStatusQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionProductStatusQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionProductStatusQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}