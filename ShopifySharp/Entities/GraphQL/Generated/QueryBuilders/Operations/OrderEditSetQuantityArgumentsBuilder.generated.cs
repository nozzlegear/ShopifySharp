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
    public sealed class OrderEditSetQuantityArgumentsBuilder : ArgumentsBuilderBase<OrderEditSetQuantityPayload, OrderEditSetQuantityArgumentsBuilder>
    {
        protected override OrderEditSetQuantityArgumentsBuilder Self => this;

        public OrderEditSetQuantityArgumentsBuilder(IQuery<OrderEditSetQuantityPayload> query) : base(query)
        {
        }

        public OrderEditSetQuantityArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditSetQuantityArgumentsBuilder LineItemId(string? lineItemId)
        {
            base.InnerQuery.AddArgument("lineItemId", lineItemId);
            return this;
        }

        public OrderEditSetQuantityArgumentsBuilder Quantity(int? quantity)
        {
            base.InnerQuery.AddArgument("quantity", quantity);
            return this;
        }

        public OrderEditSetQuantityArgumentsBuilder Restock(bool? restock)
        {
            base.InnerQuery.AddArgument("restock", restock);
            return this;
        }
    }
}