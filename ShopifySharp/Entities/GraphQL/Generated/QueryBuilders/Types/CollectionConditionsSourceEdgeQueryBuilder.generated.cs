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
    public sealed class CollectionConditionsSourceEdgeQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourceEdge, CollectionConditionsSourceEdgeQueryBuilder>
    {
        protected override CollectionConditionsSourceEdgeQueryBuilder Self => this;

        public CollectionConditionsSourceEdgeQueryBuilder() : this("collectionConditionsSourceEdge")
        {
        }

        public CollectionConditionsSourceEdgeQueryBuilder(string name) : base(new Query<CollectionConditionsSourceEdge>(name))
        {
        }

        public CollectionConditionsSourceEdgeQueryBuilder(IQuery<CollectionConditionsSourceEdge> query) : base(query)
        {
        }

        public CollectionConditionsSourceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CollectionConditionsSourceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSource>(query);
            return this;
        }
    }
}