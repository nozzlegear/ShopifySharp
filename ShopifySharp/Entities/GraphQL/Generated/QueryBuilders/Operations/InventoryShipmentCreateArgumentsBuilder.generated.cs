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
    public sealed class InventoryShipmentCreateArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentCreatePayload, InventoryShipmentCreateArgumentsBuilder>
    {
        protected override InventoryShipmentCreateArgumentsBuilder Self => this;

        public InventoryShipmentCreateArgumentsBuilder(IQuery<InventoryShipmentCreatePayload> query) : base(query)
        {
        }

        public InventoryShipmentCreateArgumentsBuilder Input(InventoryShipmentCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}