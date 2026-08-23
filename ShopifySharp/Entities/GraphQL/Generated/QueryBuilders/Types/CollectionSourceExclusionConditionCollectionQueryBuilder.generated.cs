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
    public sealed class CollectionSourceExclusionConditionCollectionQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusionConditionCollection, CollectionSourceExclusionConditionCollectionQueryBuilder>
    {
        protected override CollectionSourceExclusionConditionCollectionQueryBuilder Self => this;

        public CollectionSourceExclusionConditionCollectionQueryBuilder() : this("collectionSourceExclusionConditionCollection")
        {
        }

        public CollectionSourceExclusionConditionCollectionQueryBuilder(string name) : base(new Query<CollectionSourceExclusionConditionCollection>(name))
        {
        }

        public CollectionSourceExclusionConditionCollectionQueryBuilder(IQuery<CollectionSourceExclusionConditionCollection> query) : base(query)
        {
        }

        public CollectionSourceExclusionConditionCollectionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionSourceExclusionConditionCollectionQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionConditionCollectionQueryBuilder Values(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("values");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }
    }
}