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
    public sealed class InventoryShipmentLineItemsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, InventoryShipmentLineItemsCountArgumentsBuilder>
    {
        protected override InventoryShipmentLineItemsCountArgumentsBuilder Self => this;

        public InventoryShipmentLineItemsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public InventoryShipmentLineItemsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public InventoryShipmentLineItemsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}