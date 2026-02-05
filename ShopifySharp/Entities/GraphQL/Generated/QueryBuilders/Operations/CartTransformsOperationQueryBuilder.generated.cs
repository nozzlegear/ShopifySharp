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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CartTransformsOperationQueryBuilder : FieldsQueryBuilderBase<CartTransformConnection, CartTransformsOperationQueryBuilder>, IGraphOperationQueryBuilder<CartTransformConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CartTransformsArgumentsBuilder Arguments { get; }
        protected override CartTransformsOperationQueryBuilder Self => this;

        public CartTransformsOperationQueryBuilder() : this("cartTransforms")
        {
        }

        public CartTransformsOperationQueryBuilder(string name) : base(new Query<CartTransformConnection>(name))
        {
            Arguments = new CartTransformsArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformsOperationQueryBuilder(IQuery<CartTransformConnection> query) : base(query)
        {
            Arguments = new CartTransformsArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformEdgeQueryBuilder> build)
        {
            var query = new Query<CartTransformEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformEdge>(query);
            return this;
        }

        public CartTransformsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformQueryBuilder> build)
        {
            var query = new Query<CartTransform>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransform>(query);
            return this;
        }

        public CartTransformsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}