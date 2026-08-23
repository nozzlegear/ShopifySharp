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
    public sealed class CollectionSourceInclusionConditionProductTypeQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionProductType, CollectionSourceInclusionConditionProductTypeQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionProductTypeQueryBuilder Self => this;

        public CollectionSourceInclusionConditionProductTypeQueryBuilder() : this("collectionSourceInclusionConditionProductType")
        {
        }

        public CollectionSourceInclusionConditionProductTypeQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionProductType>(name))
        {
        }

        public CollectionSourceInclusionConditionProductTypeQueryBuilder(IQuery<CollectionSourceInclusionConditionProductType> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionProductTypeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionProductTypeQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionProductTypeQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionProductTypeQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}