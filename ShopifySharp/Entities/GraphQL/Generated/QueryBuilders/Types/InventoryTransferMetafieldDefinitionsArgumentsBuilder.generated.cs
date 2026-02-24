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
    public sealed class InventoryTransferMetafieldDefinitionsArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConnection?, InventoryTransferMetafieldDefinitionsArgumentsBuilder>
    {
        protected override InventoryTransferMetafieldDefinitionsArgumentsBuilder Self => this;

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder(IQuery<MetafieldDefinitionConnection?> query) : base(query)
        {
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder PinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
        {
            base.InnerQuery.AddArgument("pinnedStatus", pinnedStatus);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public InventoryTransferMetafieldDefinitionsArgumentsBuilder SortKey(MetafieldDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}