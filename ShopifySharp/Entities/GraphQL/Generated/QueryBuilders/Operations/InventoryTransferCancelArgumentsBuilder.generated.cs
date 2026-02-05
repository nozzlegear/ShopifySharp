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
    public sealed class InventoryTransferCancelArgumentsBuilder : ArgumentsBuilderBase<InventoryTransferCancelPayload, InventoryTransferCancelArgumentsBuilder>
    {
        protected override InventoryTransferCancelArgumentsBuilder Self => this;

        public InventoryTransferCancelArgumentsBuilder(IQuery<InventoryTransferCancelPayload> query) : base(query)
        {
        }

        public InventoryTransferCancelArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}