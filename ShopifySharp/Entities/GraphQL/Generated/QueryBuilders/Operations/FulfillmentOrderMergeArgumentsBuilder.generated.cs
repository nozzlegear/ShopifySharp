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
    public sealed class FulfillmentOrderMergeArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderMergePayload, FulfillmentOrderMergeArgumentsBuilder>
    {
        protected override FulfillmentOrderMergeArgumentsBuilder Self => this;

        public FulfillmentOrderMergeArgumentsBuilder(IQuery<FulfillmentOrderMergePayload> query) : base(query)
        {
        }

        public FulfillmentOrderMergeArgumentsBuilder FulfillmentOrderMergeInputs(ICollection<FulfillmentOrderMergeInput>? fulfillmentOrderMergeInputs)
        {
            base.InnerQuery.AddArgument("fulfillmentOrderMergeInputs", fulfillmentOrderMergeInputs);
            return this;
        }
    }
}