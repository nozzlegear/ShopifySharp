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
    public sealed class CollectionSourceExclusionConditionInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICollectionSourceExclusionCondition, CollectionSourceExclusionConditionInterfaceCasesBuilder>
    {
        protected override CollectionSourceExclusionConditionInterfaceCasesBuilder Self => this;

        public CollectionSourceExclusionConditionInterfaceCasesBuilder(string fieldName = "collectionSourceExclusionCondition") : this(new Query<ICollectionSourceExclusionCondition>(fieldName))
        {
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder(IQuery<ICollectionSourceExclusionCondition> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder OnCollectionSourceExclusionConditionCollection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionCollectionQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionCollection>("... on CollectionSourceExclusionConditionCollection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionCollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder OnCollectionSourceExclusionConditionProductCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductCategoryQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductCategory>("... on CollectionSourceExclusionConditionProductCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder OnCollectionSourceExclusionConditionProductTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTagQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductTag>("... on CollectionSourceExclusionConditionProductTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder OnCollectionSourceExclusionConditionProductType(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTypeQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductType>("... on CollectionSourceExclusionConditionProductType");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder OnCollectionSourceExclusionConditionProductVendor(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductVendorQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionProductVendor>("... on CollectionSourceExclusionConditionProductVendor");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionProductVendorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceExclusionConditionInterfaceCasesBuilder OnCollectionSourceExclusionConditionUnknown(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionUnknownQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusionConditionUnknown>("... on CollectionSourceExclusionConditionUnknown");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionConditionUnknownQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}