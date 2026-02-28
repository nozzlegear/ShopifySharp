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
    public sealed class InventoryItemVariantsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantConnection?, InventoryItemVariantsArgumentsBuilder>
    {
        protected override InventoryItemVariantsArgumentsBuilder Self => this;

        public InventoryItemVariantsArgumentsBuilder(IQuery<ProductVariantConnection?> query) : base(query)
        {
        }

        public InventoryItemVariantsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public InventoryItemVariantsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public InventoryItemVariantsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public InventoryItemVariantsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}