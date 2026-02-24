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
    public sealed class LocationInventoryLevelArgumentsBuilder : ArgumentsBuilderBase<InventoryLevel?, LocationInventoryLevelArgumentsBuilder>
    {
        protected override LocationInventoryLevelArgumentsBuilder Self => this;

        public LocationInventoryLevelArgumentsBuilder(IQuery<InventoryLevel?> query) : base(query)
        {
        }

        public LocationInventoryLevelArgumentsBuilder InventoryItemId(string? inventoryItemId)
        {
            base.InnerQuery.AddArgument("inventoryItemId", inventoryItemId);
            return this;
        }
    }
}