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
    public sealed class InventoryTransferArgumentsBuilder : ArgumentsBuilderBase<InventoryTransfer, InventoryTransferArgumentsBuilder>
    {
        protected override InventoryTransferArgumentsBuilder Self => this;

        public InventoryTransferArgumentsBuilder(IQuery<InventoryTransfer> query) : base(query)
        {
        }

        public InventoryTransferArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}