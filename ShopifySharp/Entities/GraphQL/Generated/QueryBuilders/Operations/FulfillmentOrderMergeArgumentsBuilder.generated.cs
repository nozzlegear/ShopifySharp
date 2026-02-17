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