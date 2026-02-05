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
    public sealed class InventoryShipmentUpdateItemQuantitiesArgumentsBuilder : ArgumentsBuilderBase<InventoryShipmentUpdateItemQuantitiesPayload, InventoryShipmentUpdateItemQuantitiesArgumentsBuilder>
    {
        protected override InventoryShipmentUpdateItemQuantitiesArgumentsBuilder Self => this;

        public InventoryShipmentUpdateItemQuantitiesArgumentsBuilder(IQuery<InventoryShipmentUpdateItemQuantitiesPayload> query) : base(query)
        {
        }

        public InventoryShipmentUpdateItemQuantitiesArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public InventoryShipmentUpdateItemQuantitiesArgumentsBuilder Items(ICollection<InventoryShipmentUpdateItemQuantitiesInput>? items)
        {
            base.InnerQuery.AddArgument("items", items);
            return this;
        }
    }
}