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
    public sealed class InventoryShipmentCreateInTransitArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentCreateInTransitPayload, InventoryShipmentCreateInTransitArgumentsBuilder>
    {
        protected override InventoryShipmentCreateInTransitArgumentsBuilder Self => this;

        public InventoryShipmentCreateInTransitArgumentsBuilder(IQuery<InventoryShipmentCreateInTransitPayload> query) : base(query)
        {
        }

        public InventoryShipmentCreateInTransitArgumentsBuilder Input(InventoryShipmentCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}