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
    public sealed class MarketsResolvedValuesArgumentsBuilder : ArgumentsBuilderBase<MarketsResolvedValues, MarketsResolvedValuesArgumentsBuilder>
    {
        protected override MarketsResolvedValuesArgumentsBuilder Self => this;

        public MarketsResolvedValuesArgumentsBuilder(IQuery<MarketsResolvedValues> query) : base(query)
        {
        }

        public MarketsResolvedValuesArgumentsBuilder BuyerSignal(BuyerSignalInput? buyerSignal)
        {
            base.InnerQuery.AddArgument("buyerSignal", buyerSignal);
            return this;
        }
    }
}