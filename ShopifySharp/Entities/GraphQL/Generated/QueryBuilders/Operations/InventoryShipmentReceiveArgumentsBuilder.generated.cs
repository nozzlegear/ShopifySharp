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
    public sealed class InventoryShipmentReceiveArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentReceivePayload, InventoryShipmentReceiveArgumentsBuilder>
    {
        protected override InventoryShipmentReceiveArgumentsBuilder Self => this;

        public InventoryShipmentReceiveArgumentsBuilder(IQuery<InventoryShipmentReceivePayload> query) : base(query)
        {
        }

        public InventoryShipmentReceiveArgumentsBuilder BulkReceiveAction(InventoryShipmentReceiveLineItemReason? bulkReceiveAction)
        {
            base.InnerQuery.AddArgument("bulkReceiveAction", bulkReceiveAction);
            return this;
        }

        public InventoryShipmentReceiveArgumentsBuilder DateReceived(DateTimeOffset? dateReceived)
        {
            base.InnerQuery.AddArgument("dateReceived", dateReceived);
            return this;
        }

        public InventoryShipmentReceiveArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public InventoryShipmentReceiveArgumentsBuilder LineItems(ICollection<InventoryShipmentReceiveItemInput>? lineItems)
        {
            base.InnerQuery.AddArgument("lineItems", lineItems);
            return this;
        }
    }
}