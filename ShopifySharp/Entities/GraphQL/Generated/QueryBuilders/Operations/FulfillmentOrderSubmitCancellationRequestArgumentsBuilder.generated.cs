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
    public sealed class FulfillmentOrderSubmitCancellationRequestArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderSubmitCancellationRequestPayload, FulfillmentOrderSubmitCancellationRequestArgumentsBuilder>
    {
        protected override FulfillmentOrderSubmitCancellationRequestArgumentsBuilder Self => this;

        public FulfillmentOrderSubmitCancellationRequestArgumentsBuilder(IQuery<FulfillmentOrderSubmitCancellationRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderSubmitCancellationRequestArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderSubmitCancellationRequestArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}