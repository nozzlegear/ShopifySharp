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
    public sealed class FulfillmentOrderCloseArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderClosePayload, FulfillmentOrderCloseArgumentsBuilder>
    {
        protected override FulfillmentOrderCloseArgumentsBuilder Self => this;

        public FulfillmentOrderCloseArgumentsBuilder(IQuery<FulfillmentOrderClosePayload> query) : base(query)
        {
        }

        public FulfillmentOrderCloseArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderCloseArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}