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
    public sealed class CollectionSourceInclusionConditionMetafieldStringListQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionMetafieldStringList, CollectionSourceInclusionConditionMetafieldStringListQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionMetafieldStringListQueryBuilder Self => this;

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder() : this("collectionSourceInclusionConditionMetafieldStringList")
        {
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionMetafieldStringList>(name))
        {
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder(IQuery<CollectionSourceInclusionConditionMetafieldStringList> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldStringListQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}