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
    public sealed class InventoryTransferDeleteArgumentsBuilder : ArgumentsBuilderBase<InventoryTransferDeletePayload, InventoryTransferDeleteArgumentsBuilder>
    {
        protected override InventoryTransferDeleteArgumentsBuilder Self => this;

        public InventoryTransferDeleteArgumentsBuilder(IQuery<InventoryTransferDeletePayload> query) : base(query)
        {
        }

        public InventoryTransferDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}