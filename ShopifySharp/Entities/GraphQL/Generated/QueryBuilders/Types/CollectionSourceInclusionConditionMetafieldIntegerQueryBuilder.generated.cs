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
    public sealed class CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionMetafieldInteger, CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder Self => this;

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder() : this("collectionSourceInclusionConditionMetafieldInteger")
        {
        }

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionMetafieldInteger>(name))
        {
        }

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder(IQuery<CollectionSourceInclusionConditionMetafieldInteger> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldIntegerQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}