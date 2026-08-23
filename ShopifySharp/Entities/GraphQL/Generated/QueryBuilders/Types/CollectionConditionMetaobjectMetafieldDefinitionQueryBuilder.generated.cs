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
    public sealed class CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder : FieldsQueryBuilderBase<CollectionConditionMetaobjectMetafieldDefinition, CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder>
    {
        protected override CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Self => this;

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder() : this("collectionConditionMetaobjectMetafieldDefinition")
        {
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder(string name) : base(new Query<CollectionConditionMetaobjectMetafieldDefinition>(name))
        {
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder(IQuery<CollectionConditionMetaobjectMetafieldDefinition> query) : base(query)
        {
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder MetaobjectDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("metaobjectDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public CollectionConditionMetaobjectMetafieldDefinitionQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }
    }
}