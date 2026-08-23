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
    public sealed class CollectionExclusionProductSelectionEdgeQueryBuilder : FieldsQueryBuilderBase<CollectionExclusionProductSelectionEdge, CollectionExclusionProductSelectionEdgeQueryBuilder>
    {
        protected override CollectionExclusionProductSelectionEdgeQueryBuilder Self => this;

        public CollectionExclusionProductSelectionEdgeQueryBuilder() : this("collectionExclusionProductSelectionEdge")
        {
        }

        public CollectionExclusionProductSelectionEdgeQueryBuilder(string name) : base(new Query<CollectionExclusionProductSelectionEdge>(name))
        {
        }

        public CollectionExclusionProductSelectionEdgeQueryBuilder(IQuery<CollectionExclusionProductSelectionEdge> query) : base(query)
        {
        }

        public CollectionExclusionProductSelectionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CollectionExclusionProductSelectionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionQueryBuilder> build)
        {
            var query = new Query<CollectionExclusionProductSelection>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionExclusionProductSelection>(query);
            return this;
        }
    }
}