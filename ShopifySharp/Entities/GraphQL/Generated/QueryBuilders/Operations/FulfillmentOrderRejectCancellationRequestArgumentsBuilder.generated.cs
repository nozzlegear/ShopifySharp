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
    public sealed class FulfillmentOrderRejectCancellationRequestArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderRejectCancellationRequestPayload, FulfillmentOrderRejectCancellationRequestArgumentsBuilder>
    {
        protected override FulfillmentOrderRejectCancellationRequestArgumentsBuilder Self => this;

        public FulfillmentOrderRejectCancellationRequestArgumentsBuilder(IQuery<FulfillmentOrderRejectCancellationRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderRejectCancellationRequestArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderRejectCancellationRequestArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}