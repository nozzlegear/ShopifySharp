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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICollectionConditionMetafieldDefinitionInterface, CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder>
    {
        protected override CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder Self => this;

        public CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder(string fieldName = "collectionConditionMetafieldDefinitionInterface") : this(new Query<ICollectionConditionMetafieldDefinitionInterface>(fieldName))
        {
        }

        public CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder(IQuery<ICollectionConditionMetafieldDefinitionInterface> query) : base(query)
        {
        }

        public CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder OnCollectionConditionBasicMetafieldDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionBasicMetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<CollectionConditionBasicMetafieldDefinition>("... on CollectionConditionBasicMetafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionBasicMetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder OnCollectionConditionMetaobjectMetafieldDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<CollectionConditionMetaobjectMetafieldDefinition>("... on CollectionConditionMetaobjectMetafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}