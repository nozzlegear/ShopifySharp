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
    public sealed class CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusionConditionMetafieldMetaobject, CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder>
    {
        protected override CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder Self => this;

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder() : this("collectionSourceInclusionConditionMetafieldMetaobject")
        {
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder(string name) : base(new Query<CollectionSourceInclusionConditionMetafieldMetaobject>(name))
        {
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder(IQuery<CollectionSourceInclusionConditionMetafieldMetaobject> query) : base(query)
        {
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder Definition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("definition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder Relation()
        {
            base.InnerQuery.AddField("relation");
            return this;
        }

        public CollectionSourceInclusionConditionMetafieldMetaobjectQueryBuilder Value(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("value");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }
    }
}