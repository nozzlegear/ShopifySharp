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
    public sealed class CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionMetafieldMetaobjectList, CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder Self => this;

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder() : this("collectionSourceInclusionConditionMetafieldMetaobjectList")
        {
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionMetafieldMetaobjectList>(name))
        {
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder(IQuery<CollectionSourceInclusionConditionMetafieldMetaobjectList> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectListQueryBuilder Values(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("values");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }
    }
}