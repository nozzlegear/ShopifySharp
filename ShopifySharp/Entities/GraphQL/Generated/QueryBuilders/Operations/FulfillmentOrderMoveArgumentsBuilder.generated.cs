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
    public sealed class FulfillmentOrderMoveArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderMovePayload, FulfillmentOrderMoveArgumentsBuilder>
    {
        protected override FulfillmentOrderMoveArgumentsBuilder Self => this;

        public FulfillmentOrderMoveArgumentsBuilder(IQuery<FulfillmentOrderMovePayload> query) : base(query)
        {
        }

        public FulfillmentOrderMoveArgumentsBuilder FulfillmentOrderLineItems(ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems)
        {
            base.InnerQuery.AddArgument("fulfillmentOrderLineItems", fulfillmentOrderLineItems);
            return this;
        }

        public FulfillmentOrderMoveArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderMoveArgumentsBuilder NewLocationId(string? newLocationId)
        {
            base.InnerQuery.AddArgument("newLocationId", newLocationId);
            return this;
        }
    }
}