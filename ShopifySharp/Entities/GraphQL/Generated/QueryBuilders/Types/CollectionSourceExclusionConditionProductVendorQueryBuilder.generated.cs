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
    public sealed class CollectionSourceExclusionConditionProductVendorQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionProductVendor, CollectionSourceExclusionConditionProductVendorQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionProductVendorQueryBuilder Self => this;

        public CollectionSourceExclusionConditionProductVendorQueryBuilder() : this("collectionSourceExclusionConditionProductVendor")
        {
        }

        public CollectionSourceExclusionConditionProductVendorQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionProductVendor>(name))
        {
        }

        public CollectionSourceExclusionConditionProductVendorQueryBuilder(IQuery<CollectionSourceExclusionConditionProductVendor> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionProductVendorQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionProductVendorQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionConditionProductVendorQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceExclusionConditionProductVendorQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}