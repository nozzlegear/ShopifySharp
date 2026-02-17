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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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