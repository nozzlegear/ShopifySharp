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
    public sealed class CollectionSourceExclusionConditionProductTypeQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionProductType, CollectionSourceExclusionConditionProductTypeQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionProductTypeQueryBuilder Self => this;

        public CollectionSourceExclusionConditionProductTypeQueryBuilder() : this("collectionSourceExclusionConditionProductType")
        {
        }

        public CollectionSourceExclusionConditionProductTypeQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionProductType>(name))
        {
        }

        public CollectionSourceExclusionConditionProductTypeQueryBuilder(IQuery<CollectionSourceExclusionConditionProductType> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionProductTypeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionProductTypeQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionConditionProductTypeQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceExclusionConditionProductTypeQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}