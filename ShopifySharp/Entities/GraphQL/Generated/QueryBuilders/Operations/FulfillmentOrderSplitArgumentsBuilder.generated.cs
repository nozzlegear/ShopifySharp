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
    public sealed class FulfillmentOrderSplitArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderSplitPayload, FulfillmentOrderSplitArgumentsBuilder>
    {
        protected override FulfillmentOrderSplitArgumentsBuilder Self => this;

        public FulfillmentOrderSplitArgumentsBuilder(IQuery<FulfillmentOrderSplitPayload> query) : base(query)
        {
        }

        public FulfillmentOrderSplitArgumentsBuilder FulfillmentOrderSplits(ICollection<FulfillmentOrderSplitInput>? fulfillmentOrderSplits)
        {
            base.InnerQuery.AddArgument("fulfillmentOrderSplits", fulfillmentOrderSplits);
            return this;
        }
    }
}