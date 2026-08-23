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
    public sealed class CollectionConditionsSourcesByAppEdgeQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourcesByAppEdge, CollectionConditionsSourcesByAppEdgeQueryBuilder>
    {
        protected override CollectionConditionsSourcesByAppEdgeQueryBuilder Self => this;

        public CollectionConditionsSourcesByAppEdgeQueryBuilder() : this("collectionConditionsSourcesByAppEdge")
        {
        }

        public CollectionConditionsSourcesByAppEdgeQueryBuilder(string name) : base(new Query<CollectionConditionsSourcesByAppEdge>(name))
        {
        }

        public CollectionConditionsSourcesByAppEdgeQueryBuilder(IQuery<CollectionConditionsSourcesByAppEdge> query) : base(query)
        {
        }

        public CollectionConditionsSourcesByAppEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CollectionConditionsSourcesByAppEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSourcesByApp>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourcesByAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSourcesByApp>(query);
            return this;
        }
    }
}