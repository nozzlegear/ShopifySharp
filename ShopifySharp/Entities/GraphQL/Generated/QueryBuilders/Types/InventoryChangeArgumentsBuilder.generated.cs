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
    public sealed class InventoryChangeArgumentsBuilder : ArgumentsBuilderBase<InventoryChange, InventoryChangeArgumentsBuilder>
    {
        protected override InventoryChangeArgumentsBuilder Self => this;

        public InventoryChangeArgumentsBuilder(IQuery<InventoryChange> query) : base(query)
        {
        }

        public InventoryChangeArgumentsBuilder InventoryItemIds(ICollection<string>? inventoryItemIds)
        {
            base.InnerQuery.AddArgument("inventoryItemIds", inventoryItemIds);
            return this;
        }

        public InventoryChangeArgumentsBuilder LocationIds(ICollection<string>? locationIds)
        {
            base.InnerQuery.AddArgument("locationIds", locationIds);
            return this;
        }

        public InventoryChangeArgumentsBuilder QuantityNames(ICollection<string>? quantityNames)
        {
            base.InnerQuery.AddArgument("quantityNames", quantityNames);
            return this;
        }
    }
}