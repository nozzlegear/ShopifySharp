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
    public sealed class CollectionSourceExclusionConditionQueryBuilder : FieldsQueryBuilderBase<ICollectionSourceExclusionCondition, CollectionSourceExclusionConditionQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionQueryBuilder Self => this;

        public CollectionSourceExclusionConditionQueryBuilder() : this("collectionSourceExclusionCondition")
        {
        }

        public CollectionSourceExclusionConditionQueryBuilder(string name) : base(new Query<ICollectionSourceExclusionCondition>(name))
        {
        }

        public CollectionSourceExclusionConditionQueryBuilder(IQuery<ICollectionSourceExclusionCondition> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder OnCollectionSourceExclusionConditionCollection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionCollectionQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionCollection>("... on CollectionSourceExclusionConditionCollection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionCollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder OnCollectionSourceExclusionConditionProductCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductCategoryQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductCategory>("... on CollectionSourceExclusionConditionProductCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder OnCollectionSourceExclusionConditionProductTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTagQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductTag>("... on CollectionSourceExclusionConditionProductTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder OnCollectionSourceExclusionConditionProductType(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTypeQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductType>("... on CollectionSourceExclusionConditionProductType");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder OnCollectionSourceExclusionConditionProductVendor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductVendorQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductVendor>("... on CollectionSourceExclusionConditionProductVendor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductVendorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder OnCollectionSourceExclusionConditionUnknown(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionUnknownQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionUnknown>("... on CollectionSourceExclusionConditionUnknown");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionUnknownQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionSourceExclusionConditionQueryBuilder CollectionSourceExclusionCondition(Action<CollectionSourceExclusionConditionInterfaceCasesBuilder> build)
        {
            var query = new Query<ICollectionSourceExclusionCondition>("collectionSourceExclusionCondition");
            var unionBuilder = new CollectionSourceExclusionConditionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}