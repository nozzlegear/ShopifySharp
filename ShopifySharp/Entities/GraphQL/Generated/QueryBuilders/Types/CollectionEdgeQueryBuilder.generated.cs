#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CollectionEdgeQueryBuilder : FieldsQueryBuilderBase<CollectionEdge, CollectionEdgeQueryBuilder>
    {
        protected override CollectionEdgeQueryBuilder Self => this;

        public CollectionEdgeQueryBuilder() : this("collectionEdge")
        {
        }

        public CollectionEdgeQueryBuilder(string name) : base(new Query<CollectionEdge>(name))
        {
        }

        public CollectionEdgeQueryBuilder(IQuery<CollectionEdge> query) : base(query)
        {
        }

        public CollectionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CollectionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }
    }
}