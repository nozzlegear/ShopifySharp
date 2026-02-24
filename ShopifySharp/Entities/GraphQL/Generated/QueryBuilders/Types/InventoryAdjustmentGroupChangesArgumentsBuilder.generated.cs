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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class InventoryAdjustmentGroupChangesArgumentsBuilder : ArgumentsBuilderBase<InventoryChange?, InventoryAdjustmentGroupChangesArgumentsBuilder>
    {
        protected override InventoryAdjustmentGroupChangesArgumentsBuilder Self => this;

        public InventoryAdjustmentGroupChangesArgumentsBuilder(IQuery<InventoryChange?> query) : base(query)
        {
        }

        public InventoryAdjustmentGroupChangesArgumentsBuilder InventoryItemIds(ICollection<string>? inventoryItemIds)
        {
            base.InnerQuery.AddArgument("inventoryItemIds", inventoryItemIds);
            return this;
        }

        public InventoryAdjustmentGroupChangesArgumentsBuilder LocationIds(ICollection<string>? locationIds)
        {
            base.InnerQuery.AddArgument("locationIds", locationIds);
            return this;
        }

        public InventoryAdjustmentGroupChangesArgumentsBuilder QuantityNames(ICollection<string>? quantityNames)
        {
            base.InnerQuery.AddArgument("quantityNames", quantityNames);
            return this;
        }
    }
}