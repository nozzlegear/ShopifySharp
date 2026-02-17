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
    public sealed class FulfillmentCreateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentCreatePayload, FulfillmentCreateArgumentsBuilder>
    {
        protected override FulfillmentCreateArgumentsBuilder Self => this;

        public FulfillmentCreateArgumentsBuilder(IQuery<FulfillmentCreatePayload> query) : base(query)
        {
        }

        public FulfillmentCreateArgumentsBuilder Fulfillment(FulfillmentInput? fulfillment)
        {
            base.InnerQuery.AddArgument("fulfillment", fulfillment);
            return this;
        }

        public FulfillmentCreateArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}