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
    public sealed class CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionMetafieldBoolean, CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder Self => this;

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder() : this("collectionSourceInclusionConditionMetafieldBoolean")
        {
        }

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionMetafieldBoolean>(name))
        {
        }

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder(IQuery<CollectionSourceInclusionConditionMetafieldBoolean> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldBooleanQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}