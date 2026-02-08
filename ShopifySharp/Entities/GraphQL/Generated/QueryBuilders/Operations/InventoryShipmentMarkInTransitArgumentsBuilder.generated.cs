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
    public sealed class InventoryShipmentMarkInTransitArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentMarkInTransitPayload, InventoryShipmentMarkInTransitArgumentsBuilder>
    {
        protected override InventoryShipmentMarkInTransitArgumentsBuilder Self => this;

        public InventoryShipmentMarkInTransitArgumentsBuilder(IQuery<InventoryShipmentMarkInTransitPayload> query) : base(query)
        {
        }

        public InventoryShipmentMarkInTransitArgumentsBuilder DateShipped(DateTimeOffset? dateShipped)
        {
            base.InnerQuery.AddArgument("dateShipped", dateShipped);
            return this;
        }

        public InventoryShipmentMarkInTransitArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}