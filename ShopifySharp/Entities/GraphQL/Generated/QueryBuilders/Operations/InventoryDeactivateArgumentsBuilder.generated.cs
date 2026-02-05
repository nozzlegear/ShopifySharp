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
    public sealed class InventoryDeactivateArgumentsBuilder : ArgumentsBuilderBase<InventoryDeactivatePayload, InventoryDeactivateArgumentsBuilder>
    {
        protected override InventoryDeactivateArgumentsBuilder Self => this;

        public InventoryDeactivateArgumentsBuilder(IQuery<InventoryDeactivatePayload> query) : base(query)
        {
        }

        public InventoryDeactivateArgumentsBuilder InventoryLevelId(string? inventoryLevelId)
        {
            base.InnerQuery.AddArgument("inventoryLevelId", inventoryLevelId);
            return this;
        }
    }
}