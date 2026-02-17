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
    public sealed class FulfillmentOrderAcceptCancellationRequestArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderAcceptCancellationRequestPayload, FulfillmentOrderAcceptCancellationRequestArgumentsBuilder>
    {
        protected override FulfillmentOrderAcceptCancellationRequestArgumentsBuilder Self => this;

        public FulfillmentOrderAcceptCancellationRequestArgumentsBuilder(IQuery<FulfillmentOrderAcceptCancellationRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderAcceptCancellationRequestArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderAcceptCancellationRequestArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}