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
    public sealed class CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionMetafieldDecimal, CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder Self => this;

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder() : this("collectionSourceInclusionConditionMetafieldDecimal")
        {
        }

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionMetafieldDecimal>(name))
        {
        }

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder(IQuery<CollectionSourceInclusionConditionMetafieldDecimal> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldDecimalQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}