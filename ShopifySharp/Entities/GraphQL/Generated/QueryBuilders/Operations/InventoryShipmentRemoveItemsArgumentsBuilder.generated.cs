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
    public sealed class InventoryShipmentRemoveItemsArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentRemoveItemsPayload, InventoryShipmentRemoveItemsArgumentsBuilder>
    {
        protected override InventoryShipmentRemoveItemsArgumentsBuilder Self => this;

        public InventoryShipmentRemoveItemsArgumentsBuilder(IQuery<InventoryShipmentRemoveItemsPayload> query) : base(query)
        {
        }

        public InventoryShipmentRemoveItemsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public InventoryShipmentRemoveItemsArgumentsBuilder LineItems(ICollection<string>? lineItems)
        {
            base.InnerQuery.AddArgument("lineItems", lineItems);
            return this;
        }
    }
}