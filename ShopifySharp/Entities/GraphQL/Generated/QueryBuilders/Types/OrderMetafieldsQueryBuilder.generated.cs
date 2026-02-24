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
    public sealed class OrderMetafieldsQueryBuilder : FieldsQueryBuilderBase<MetafieldConnection, OrderMetafieldsQueryBuilder>, IHasArguments<OrderMetafieldsArgumentsBuilder>
    {
        public OrderMetafieldsArgumentsBuilder Arguments { get; }
        protected override OrderMetafieldsQueryBuilder Self => this;

        public OrderMetafieldsQueryBuilder(string name) : base(new Query<MetafieldConnection>(name))
        {
            Arguments = new OrderMetafieldsArgumentsBuilder(base.InnerQuery);
        }

        public OrderMetafieldsQueryBuilder(IQuery<MetafieldConnection> query) : base(query)
        {
            Arguments = new OrderMetafieldsArgumentsBuilder(base.InnerQuery);
        }

        public OrderMetafieldsQueryBuilder SetArguments(Action<OrderMetafieldsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderMetafieldsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldEdge>(query);
            return this;
        }

        public OrderMetafieldsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public OrderMetafieldsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}