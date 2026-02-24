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
    public sealed class ShopInventoryItemsQueryBuilder : FieldsQueryBuilderBase<InventoryItemConnection, ShopInventoryItemsQueryBuilder>, IHasArguments<ShopInventoryItemsArgumentsBuilder>
    {
        public ShopInventoryItemsArgumentsBuilder Arguments { get; }
        protected override ShopInventoryItemsQueryBuilder Self => this;

        public ShopInventoryItemsQueryBuilder(string name) : base(new Query<InventoryItemConnection>(name))
        {
            Arguments = new ShopInventoryItemsArgumentsBuilder(base.InnerQuery);
        }

        public ShopInventoryItemsQueryBuilder(IQuery<InventoryItemConnection> query) : base(query)
        {
            Arguments = new ShopInventoryItemsArgumentsBuilder(base.InnerQuery);
        }

        public ShopInventoryItemsQueryBuilder SetArguments(Action<ShopInventoryItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopInventoryItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemEdge>(query);
            return this;
        }

        public ShopInventoryItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public ShopInventoryItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}