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
    public sealed class FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrdersSetFulfillmentDeadlinePayload, FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder>
    {
        protected override FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder Self => this;

        public FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder(IQuery<FulfillmentOrdersSetFulfillmentDeadlinePayload> query) : base(query)
        {
        }

        public FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder FulfillmentDeadline(DateTimeOffset? fulfillmentDeadline)
        {
            base.InnerQuery.AddArgument("fulfillmentDeadline", fulfillmentDeadline);
            return this;
        }

        public FulfillmentOrdersSetFulfillmentDeadlineArgumentsBuilder FulfillmentOrderIds(ICollection<string>? fulfillmentOrderIds)
        {
            base.InnerQuery.AddArgument("fulfillmentOrderIds", fulfillmentOrderIds);
            return this;
        }
    }
}