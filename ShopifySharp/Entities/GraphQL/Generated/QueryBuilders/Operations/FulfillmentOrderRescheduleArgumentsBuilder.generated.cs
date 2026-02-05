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
    public sealed class FulfillmentOrderRescheduleArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderReschedulePayload, FulfillmentOrderRescheduleArgumentsBuilder>
    {
        protected override FulfillmentOrderRescheduleArgumentsBuilder Self => this;

        public FulfillmentOrderRescheduleArgumentsBuilder(IQuery<FulfillmentOrderReschedulePayload> query) : base(query)
        {
        }

        public FulfillmentOrderRescheduleArgumentsBuilder FulfillAt(DateTimeOffset? fulfillAt)
        {
            base.InnerQuery.AddArgument("fulfillAt", fulfillAt);
            return this;
        }

        public FulfillmentOrderRescheduleArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}