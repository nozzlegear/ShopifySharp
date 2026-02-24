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
    public sealed class InventoryLevelQuantitiesArgumentsBuilder : ArgumentsBuilderBase<InventoryQuantity?, InventoryLevelQuantitiesArgumentsBuilder>
    {
        protected override InventoryLevelQuantitiesArgumentsBuilder Self => this;

        public InventoryLevelQuantitiesArgumentsBuilder(IQuery<InventoryQuantity?> query) : base(query)
        {
        }

        public InventoryLevelQuantitiesArgumentsBuilder Names(ICollection<string>? names)
        {
            base.InnerQuery.AddArgument("names", names);
            return this;
        }
    }
}