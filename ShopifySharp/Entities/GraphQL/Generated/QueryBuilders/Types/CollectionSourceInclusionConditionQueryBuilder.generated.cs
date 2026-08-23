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
    public sealed class CollectionSourceInclusionConditionQueryBuilder : FieldsQueryBuilderBase<ICollectionSourceInclusionCondition, CollectionSourceInclusionConditionQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionQueryBuilder Self => this;

        public CollectionSourceInclusionConditionQueryBuilder() : this("collectionSourceInclusionCondition")
        {
        }

        public CollectionSourceInclusionConditionQueryBuilder(string name) : base(new Query<ICollectionSourceInclusionCondition>(name))
        {
        }

        public CollectionSourceInclusionConditionQueryBuilder(IQuery<ICollectionSourceInclusionCondition> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldBoolean(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldBoolean>("... on CollectionSourceInclusionConditionMetafieldBoolean");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldDecimal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldDecimal>("... on CollectionSourceInclusionConditionMetafieldDecimal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldInteger(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldInteger>("... on CollectionSourceInclusionConditionMetafieldInteger");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldMetaobject(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldMetaobject>("... on CollectionSourceInclusionConditionMetafieldMetaobject");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldMetaobjectList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldMetaobjectList>("... on CollectionSourceInclusionConditionMetafieldMetaobjectList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldString(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldString>("... on CollectionSourceInclusionConditionMetafieldString");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionMetafieldStringList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringListQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldStringList>("... on CollectionSourceInclusionConditionMetafieldStringList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionProductCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductCategoryQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductCategory>("... on CollectionSourceInclusionConditionProductCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionProductStatus(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductStatusQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductStatus>("... on CollectionSourceInclusionConditionProductStatus");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductStatusQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionProductTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTagQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductTag>("... on CollectionSourceInclusionConditionProductTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionProductTitle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTitleQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductTitle>("... on CollectionSourceInclusionConditionProductTitle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTitleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionProductType(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTypeQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductType>("... on CollectionSourceInclusionConditionProductType");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionProductVendor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductVendorQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductVendor>("... on CollectionSourceInclusionConditionProductVendor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductVendorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionUnknown(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionUnknownQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionUnknown>("... on CollectionSourceInclusionConditionUnknown");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionUnknownQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionVariantCompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantCompareAtPrice>("... on CollectionSourceInclusionConditionVariantCompareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionVariantInventory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantInventoryQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantInventory>("... on CollectionSourceInclusionConditionVariantInventory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantInventoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionVariantPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantPriceQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantPrice>("... on CollectionSourceInclusionConditionVariantPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionVariantTitle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantTitleQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantTitle>("... on CollectionSourceInclusionConditionVariantTitle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantTitleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder OnCollectionSourceInclusionConditionVariantWeight(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantWeightQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantWeight>("... on CollectionSourceInclusionConditionVariantWeight");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantWeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceInclusionConditionQueryBuilder CollectionSourceInclusionCondition(Action<CollectionSourceInclusionConditionInterfaceCasesBuilder> build)
        {
            var query = new Query<ICollectionSourceInclusionCondition>("collectionSourceInclusionCondition");
            var unionBuilder = new CollectionSourceInclusionConditionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}