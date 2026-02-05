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
    public sealed class InventoryShipmentAddItemsArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentAddItemsPayload, InventoryShipmentAddItemsArgumentsBuilder>
    {
        protected override InventoryShipmentAddItemsArgumentsBuilder Self => this;

        public InventoryShipmentAddItemsArgumentsBuilder(IQuery<InventoryShipmentAddItemsPayload> query) : base(query)
        {
        }

        public InventoryShipmentAddItemsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public InventoryShipmentAddItemsArgumentsBuilder LineItems(ICollection<InventoryShipmentLineItemInput>? lineItems)
        {
            base.InnerQuery.AddArgument("lineItems", lineItems);
            return this;
        }
    }
}