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
    public sealed class InventoryLevelArgumentsBuilder : ArgumentsBuilderBase<InventoryLevel, InventoryLevelArgumentsBuilder>
    {
        protected override InventoryLevelArgumentsBuilder Self => this;

        public InventoryLevelArgumentsBuilder(IQuery<InventoryLevel> query) : base(query)
        {
        }

        public InventoryLevelArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public InventoryLevelArgumentsBuilder InventoryItemId(string? inventoryItemId)
        {
            base.InnerQuery.AddArgument("inventoryItemId", inventoryItemId);
            return this;
        }

        public InventoryLevelArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}