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
    public sealed class FulfillmentEventCreateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentEventCreatePayload, FulfillmentEventCreateArgumentsBuilder>
    {
        protected override FulfillmentEventCreateArgumentsBuilder Self => this;

        public FulfillmentEventCreateArgumentsBuilder(IQuery<FulfillmentEventCreatePayload> query) : base(query)
        {
        }

        public FulfillmentEventCreateArgumentsBuilder FulfillmentEvent(FulfillmentEventInput? fulfillmentEvent)
        {
            base.InnerQuery.AddArgument("fulfillmentEvent", fulfillmentEvent);
            return this;
        }
    }
}