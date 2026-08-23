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
    public sealed class CollectionSourceInclusionConditionInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICollectionSourceInclusionCondition, CollectionSourceInclusionConditionInterfaceCasesBuilder>
    {
        protected override CollectionSourceInclusionConditionInterfaceCasesBuilder Self => this;

        public CollectionSourceInclusionConditionInterfaceCasesBuilder(string fieldName = "collectionSourceInclusionCondition") : this(new Query<ICollectionSourceInclusionCondition>(fieldName))
        {
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder(IQuery<ICollectionSourceInclusionCondition> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldBoolean(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldBoolean>("... on CollectionSourceInclusionConditionMetafieldBoolean");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldDecimal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldDecimal>("... on CollectionSourceInclusionConditionMetafieldDecimal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldInteger(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldInteger>("... on CollectionSourceInclusionConditionMetafieldInteger");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldMetaobject(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldMetaobject>("... on CollectionSourceInclusionConditionMetafieldMetaobject");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldMetaobjectList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldMetaobjectList>("... on CollectionSourceInclusionConditionMetafieldMetaobjectList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldString(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldString>("... on CollectionSourceInclusionConditionMetafieldString");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionMetafieldStringList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringListQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionMetafieldStringList>("... on CollectionSourceInclusionConditionMetafieldStringList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionMetafieldStringListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionProductCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductCategoryQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductCategory>("... on CollectionSourceInclusionConditionProductCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionProductStatus(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductStatusQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductStatus>("... on CollectionSourceInclusionConditionProductStatus");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductStatusQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionProductTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTagQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductTag>("... on CollectionSourceInclusionConditionProductTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionProductTitle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTitleQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductTitle>("... on CollectionSourceInclusionConditionProductTitle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTitleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionProductType(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTypeQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductType>("... on CollectionSourceInclusionConditionProductType");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionProductVendor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductVendorQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionProductVendor>("... on CollectionSourceInclusionConditionProductVendor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionProductVendorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionUnknown(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionUnknownQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionUnknown>("... on CollectionSourceInclusionConditionUnknown");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionUnknownQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionVariantCompareAtPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantCompareAtPrice>("... on CollectionSourceInclusionConditionVariantCompareAtPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantCompareAtPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionVariantInventory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantInventoryQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantInventory>("... on CollectionSourceInclusionConditionVariantInventory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantInventoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionVariantPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantPriceQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantPrice>("... on CollectionSourceInclusionConditionVariantPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantPriceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionVariantTitle(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantTitleQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantTitle>("... on CollectionSourceInclusionConditionVariantTitle");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantTitleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInclusionConditionInterfaceCasesBuilder OnCollectionSourceInclusionConditionVariantWeight(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantWeightQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusionConditionVariantWeight>("... on CollectionSourceInclusionConditionVariantWeight");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionConditionVariantWeightQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}