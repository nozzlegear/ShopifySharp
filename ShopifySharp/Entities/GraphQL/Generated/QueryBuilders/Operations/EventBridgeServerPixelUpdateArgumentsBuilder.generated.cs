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