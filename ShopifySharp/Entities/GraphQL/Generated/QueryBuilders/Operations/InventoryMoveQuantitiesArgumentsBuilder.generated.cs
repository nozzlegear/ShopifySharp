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
    public sealed class InventoryMoveQuantitiesArgumentsBuilder : ArgumentsBuilderBase<InventoryMoveQuantitiesPayload, InventoryMoveQuantitiesArgumentsBuilder>
    {
        protected override InventoryMoveQuantitiesArgumentsBuilder Self => this;

        public InventoryMoveQuantitiesArgumentsBuilder(IQuery<InventoryMoveQuantitiesPayload> query) : base(query)
        {
        }

        public InventoryMoveQuantitiesArgumentsBuilder Input(InventoryMoveQuantitiesInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}