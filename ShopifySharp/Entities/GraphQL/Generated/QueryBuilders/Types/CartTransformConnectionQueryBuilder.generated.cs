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
    public sealed class CartTransformConnectionQueryBuilder : FieldsQueryBuilderBase<CartTransformConnection, CartTransformConnectionQueryBuilder>, IHasArguments<CartTransformConnectionArgumentsBuilder>
    {
        public CartTransformConnectionArgumentsBuilder Arguments { get; }
        protected override CartTransformConnectionQueryBuilder Self => this;

        public CartTransformConnectionQueryBuilder() : this("cartTransformConnection")
        {
        }

        public CartTransformConnectionQueryBuilder(string name) : base(new Query<CartTransformConnection>(name))
        {
            Arguments = new CartTransformConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformConnectionQueryBuilder(IQuery<CartTransformConnection> query) : base(query)
        {
            Arguments = new CartTransformConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CartTransformConnectionQueryBuilder SetArguments(Action<CartTransformConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CartTransformConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformEdgeQueryBuilder> build)
        {
            var query = new Query<CartTransformEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformEdge>(query);
            return this;
        }

        public CartTransformConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformQueryBuilder> build)
        {
            var query = new Query<CartTransform>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransform>(query);
            return this;
        }

        public CartTransformConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}