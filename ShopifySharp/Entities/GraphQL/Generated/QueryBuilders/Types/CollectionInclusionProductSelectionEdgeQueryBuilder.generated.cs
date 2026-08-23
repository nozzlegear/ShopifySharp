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
    public sealed class CollectionInclusionProductSelectionEdgeQueryBuilder : FieldsQueryBuilderBase<CollectionInclusionProductSelectionEdge, CollectionInclusionProductSelectionEdgeQueryBuilder>
    {
        protected override CollectionInclusionProductSelectionEdgeQueryBuilder Self => this;

        public CollectionInclusionProductSelectionEdgeQueryBuilder() : this("collectionInclusionProductSelectionEdge")
        {
        }

        public CollectionInclusionProductSelectionEdgeQueryBuilder(string name) : base(new Query<CollectionInclusionProductSelectionEdge>(name))
        {
        }

        public CollectionInclusionProductSelectionEdgeQueryBuilder(IQuery<CollectionInclusionProductSelectionEdge> query) : base(query)
        {
        }

        public CollectionInclusionProductSelectionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CollectionInclusionProductSelectionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionQueryBuilder> build)
        {
            var query = new Query<CollectionInclusionProductSelection>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionInclusionProductSelection>(query);
            return this;
        }
    }
}