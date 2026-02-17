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