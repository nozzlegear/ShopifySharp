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
    public sealed class CollectionPublicationEdgeQueryBuilder : FieldsQueryBuilderBase<CollectionPublicationEdge, CollectionPublicationEdgeQueryBuilder>
    {
        protected override CollectionPublicationEdgeQueryBuilder Self => this;

        public CollectionPublicationEdgeQueryBuilder() : this("collectionPublicationEdge")
        {
        }

        public CollectionPublicationEdgeQueryBuilder(string name) : base(new Query<CollectionPublicationEdge>(name))
        {
        }

        public CollectionPublicationEdgeQueryBuilder(IQuery<CollectionPublicationEdge> query) : base(query)
        {
        }

        public CollectionPublicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CollectionPublicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationQueryBuilder> build)
        {
            var query = new Query<CollectionPublication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionPublicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionPublication>(query);
            return this;
        }
    }
}