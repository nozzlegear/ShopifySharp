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