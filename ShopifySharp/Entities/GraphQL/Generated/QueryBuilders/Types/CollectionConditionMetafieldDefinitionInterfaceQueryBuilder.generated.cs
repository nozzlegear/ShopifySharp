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
    public sealed class CollectionConditionMetafieldDefinitionInterfaceQueryBuilder : FieldsQueryBuilderBase<ICollectionConditionMetafieldDefinitionInterface, CollectionConditionMetafieldDefinitionInterfaceQueryBuilder>
    {
        protected override CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Self => this;

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder() : this("collectionConditionMetafieldDefinitionInterface")
        {
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder(string name) : base(new Query<ICollectionConditionMetafieldDefinitionInterface>(name))
        {
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder(IQuery<ICollectionConditionMetafieldDefinitionInterface> query) : base(query)
        {
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder OnCollectionConditionBasicMetafieldDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionBasicMetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<CollectionConditionBasicMetafieldDefinition>("... on CollectionConditionBasicMetafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionBasicMetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder OnCollectionConditionMetaobjectMetafieldDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<CollectionConditionMetaobjectMetafieldDefinition>("... on CollectionConditionMetaobjectMetafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CollectionConditionMetafieldDefinitionInterfaceQueryBuilder CollectionConditionMetafieldDefinitionInterface(Action<CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder> build)
        {
            var query = new Query<ICollectionConditionMetafieldDefinitionInterface>("collectionConditionMetafieldDefinitionInterface");
            var unionBuilder = new CollectionConditionMetafieldDefinitionInterfaceInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}