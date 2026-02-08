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
    public sealed class InventoryItemArgumentsBuilder : ArgumentsBuilderBase<InventoryItem, InventoryItemArgumentsBuilder>
    {
        protected override InventoryItemArgumentsBuilder Self => this;

        public InventoryItemArgumentsBuilder(IQuery<InventoryItem> query) : base(query)
        {
        }

        public InventoryItemArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}