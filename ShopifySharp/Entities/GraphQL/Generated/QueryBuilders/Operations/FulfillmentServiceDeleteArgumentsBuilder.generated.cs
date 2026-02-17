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
    public sealed class FulfillmentServiceDeleteArgumentsBuilder : ArgumentsBuilderBase<FulfillmentServiceDeletePayload, FulfillmentServiceDeleteArgumentsBuilder>
    {
        protected override FulfillmentServiceDeleteArgumentsBuilder Self => this;

        public FulfillmentServiceDeleteArgumentsBuilder(IQuery<FulfillmentServiceDeletePayload> query) : base(query)
        {
        }

        public FulfillmentServiceDeleteArgumentsBuilder DestinationLocationId(string? destinationLocationId)
        {
            base.InnerQuery.AddArgument("destinationLocationId", destinationLocationId);
            return this;
        }

        public FulfillmentServiceDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentServiceDeleteArgumentsBuilder InventoryAction(FulfillmentServiceDeleteInventoryAction? inventoryAction)
        {
            base.InnerQuery.AddArgument("inventoryAction", inventoryAction);
            return this;
        }
    }
}