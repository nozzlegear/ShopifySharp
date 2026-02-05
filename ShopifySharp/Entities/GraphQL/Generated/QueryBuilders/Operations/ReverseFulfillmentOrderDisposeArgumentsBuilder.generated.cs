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
    public sealed class ReverseFulfillmentOrderDisposeArgumentsBuilder : ArgumentsBuilderBase<ReverseFulfillmentOrderDisposePayload, ReverseFulfillmentOrderDisposeArgumentsBuilder>
    {
        protected override ReverseFulfillmentOrderDisposeArgumentsBuilder Self => this;

        public ReverseFulfillmentOrderDisposeArgumentsBuilder(IQuery<ReverseFulfillmentOrderDisposePayload> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderDisposeArgumentsBuilder DispositionInputs(ICollection<ReverseFulfillmentOrderDisposeInput>? dispositionInputs)
        {
            base.InnerQuery.AddArgument("dispositionInputs", dispositionInputs);
            return this;
        }
    }
}