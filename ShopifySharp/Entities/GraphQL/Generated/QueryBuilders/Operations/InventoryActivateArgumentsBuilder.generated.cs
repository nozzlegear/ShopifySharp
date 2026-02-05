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
    public sealed class InventoryActivateArgumentsBuilder : ArgumentsBuilderBase<InventoryActivatePayload, InventoryActivateArgumentsBuilder>
    {
        protected override InventoryActivateArgumentsBuilder Self => this;

        public InventoryActivateArgumentsBuilder(IQuery<InventoryActivatePayload> query) : base(query)
        {
        }

        public InventoryActivateArgumentsBuilder Available(int? available)
        {
            base.InnerQuery.AddArgument("available", available);
            return this;
        }

        public InventoryActivateArgumentsBuilder InventoryItemId(string? inventoryItemId)
        {
            base.InnerQuery.AddArgument("inventoryItemId", inventoryItemId);
            return this;
        }

        public InventoryActivateArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public InventoryActivateArgumentsBuilder OnHand(int? onHand)
        {
            base.InnerQuery.AddArgument("onHand", onHand);
            return this;
        }

        public InventoryActivateArgumentsBuilder StockAtLegacyLocation(bool? stockAtLegacyLocation)
        {
            base.InnerQuery.AddArgument("stockAtLegacyLocation", stockAtLegacyLocation);
            return this;
        }
    }
}