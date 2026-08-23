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
    public sealed class CollectionSourceInclusionConditionVariantInventoryQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionVariantInventory, CollectionSourceInclusionConditionVariantInventoryQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionVariantInventoryQueryBuilder Self => this;

        public CollectionSourceInclusionConditionVariantInventoryQueryBuilder() : this("collectionSourceInclusionConditionVariantInventory")
        {
        }

        public CollectionSourceInclusionConditionVariantInventoryQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionVariantInventory>(name))
        {
        }

        public CollectionSourceInclusionConditionVariantInventoryQueryBuilder(IQuery<CollectionSourceInclusionConditionVariantInventory> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionVariantInventoryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionVariantInventoryQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionVariantInventoryQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}