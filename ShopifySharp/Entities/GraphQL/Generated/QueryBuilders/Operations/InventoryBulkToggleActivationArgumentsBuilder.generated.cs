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
    public sealed class InventoryBulkToggleActivationArgumentsBuilder : ArgumentsBuilderBase<InventoryBulkToggleActivationPayload, InventoryBulkToggleActivationArgumentsBuilder>
    {
        protected override InventoryBulkToggleActivationArgumentsBuilder Self => this;

        public InventoryBulkToggleActivationArgumentsBuilder(IQuery<InventoryBulkToggleActivationPayload> query) : base(query)
        {
        }

        public InventoryBulkToggleActivationArgumentsBuilder InventoryItemId(string? inventoryItemId)
        {
            base.InnerQuery.AddArgument("inventoryItemId", inventoryItemId);
            return this;
        }

        public InventoryBulkToggleActivationArgumentsBuilder InventoryItemUpdates(ICollection<InventoryBulkToggleActivationInput>? inventoryItemUpdates)
        {
            base.InnerQuery.AddArgument("inventoryItemUpdates", inventoryItemUpdates);
            return this;
        }
    }
}