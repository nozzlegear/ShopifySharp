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
    public sealed class CollectionSourceInclusionConditionProductVendorQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionProductVendor, CollectionSourceInclusionConditionProductVendorQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionProductVendorQueryBuilder Self => this;

        public CollectionSourceInclusionConditionProductVendorQueryBuilder() : this("collectionSourceInclusionConditionProductVendor")
        {
        }

        public CollectionSourceInclusionConditionProductVendorQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionProductVendor>(name))
        {
        }

        public CollectionSourceInclusionConditionProductVendorQueryBuilder(IQuery<CollectionSourceInclusionConditionProductVendor> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionProductVendorQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionProductVendorQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionProductVendorQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionProductVendorQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}