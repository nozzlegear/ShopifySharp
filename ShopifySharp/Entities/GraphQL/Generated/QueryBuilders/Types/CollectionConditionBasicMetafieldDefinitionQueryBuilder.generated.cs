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
    public sealed class CollectionConditionBasicMetafieldDefinitionQueryBuilder : FieldsQueryBuilderBase<CollectionConditionBasicMetafieldDefinition, CollectionConditionBasicMetafieldDefinitionQueryBuilder>
    {
        protected override CollectionConditionBasicMetafieldDefinitionQueryBuilder Self => this;

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder() : this("collectionConditionBasicMetafieldDefinition")
        {
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder(string name) : base(new Query<CollectionConditionBasicMetafieldDefinition>(name))
        {
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder(IQuery<CollectionConditionBasicMetafieldDefinition> query) : base(query)
        {
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder OwnerType()
        {
            base.InnerQuery.AddField("ownerType");
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public CollectionConditionBasicMetafieldDefinitionQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }
    }
}