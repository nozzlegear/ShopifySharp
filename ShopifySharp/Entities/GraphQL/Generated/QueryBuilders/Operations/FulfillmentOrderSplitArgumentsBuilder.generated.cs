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