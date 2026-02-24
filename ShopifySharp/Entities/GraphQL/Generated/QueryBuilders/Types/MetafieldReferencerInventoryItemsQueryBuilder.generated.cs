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
    public sealed class MetafieldReferencerInventoryItemsQueryBuilder : FieldsQueryBuilderBase<InventoryItemConnection, MetafieldReferencerInventoryItemsQueryBuilder>, IHasArguments<MetafieldReferencerInventoryItemsArgumentsBuilder>
    {
        public MetafieldReferencerInventoryItemsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerInventoryItemsQueryBuilder Self => this;

        public MetafieldReferencerInventoryItemsQueryBuilder(string name) : base(new Query<InventoryItemConnection>(name))
        {
            Arguments = new MetafieldReferencerInventoryItemsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerInventoryItemsQueryBuilder(IQuery<InventoryItemConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerInventoryItemsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerInventoryItemsQueryBuilder SetArguments(Action<MetafieldReferencerInventoryItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerInventoryItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemEdge>(query);
            return this;
        }

        public MetafieldReferencerInventoryItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public MetafieldReferencerInventoryItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}