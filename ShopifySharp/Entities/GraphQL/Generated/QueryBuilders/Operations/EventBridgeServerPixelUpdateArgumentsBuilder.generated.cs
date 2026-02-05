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
    public sealed class EventBridgeServerPixelUpdateArgumentsBuilder : ArgumentsBuilderBase<EventBridgeServerPixelUpdatePayload, EventBridgeServerPixelUpdateArgumentsBuilder>
    {
        protected override EventBridgeServerPixelUpdateArgumentsBuilder Self => this;

        public EventBridgeServerPixelUpdateArgumentsBuilder(IQuery<EventBridgeServerPixelUpdatePayload> query) : base(query)
        {
        }

        public EventBridgeServerPixelUpdateArgumentsBuilder Arn(string? arn)
        {
            base.InnerQuery.AddArgument("arn", arn);
            return this;
        }
    }
}