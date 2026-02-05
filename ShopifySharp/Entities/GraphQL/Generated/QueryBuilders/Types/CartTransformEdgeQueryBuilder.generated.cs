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
    public sealed class CartTransformEdgeQueryBuilder : FieldsQueryBuilderBase<CartTransformEdge, CartTransformEdgeQueryBuilder>
    {
        protected override CartTransformEdgeQueryBuilder Self => this;

        public CartTransformEdgeQueryBuilder() : this("cartTransformEdge")
        {
        }

        public CartTransformEdgeQueryBuilder(string name) : base(new Query<CartTransformEdge>(name))
        {
        }

        public CartTransformEdgeQueryBuilder(IQuery<CartTransformEdge> query) : base(query)
        {
        }

        public CartTransformEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CartTransformEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformQueryBuilder> build)
        {
            var query = new Query<CartTransform>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransform>(query);
            return this;
        }
    }
}