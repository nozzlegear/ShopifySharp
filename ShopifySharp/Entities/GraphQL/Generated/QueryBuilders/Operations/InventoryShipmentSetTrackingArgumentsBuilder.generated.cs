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
    public sealed class InventoryShipmentSetTrackingArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentSetTrackingPayload, InventoryShipmentSetTrackingArgumentsBuilder>
    {
        protected override InventoryShipmentSetTrackingArgumentsBuilder Self => this;

        public InventoryShipmentSetTrackingArgumentsBuilder(IQuery<InventoryShipmentSetTrackingPayload> query) : base(query)
        {
        }

        public InventoryShipmentSetTrackingArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public InventoryShipmentSetTrackingArgumentsBuilder Tracking(InventoryShipmentTrackingInput? tracking)
        {
            base.InnerQuery.AddArgument("tracking", tracking);
            return this;
        }
    }
}