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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootMarketsResolvedValuesArgumentsBuilder : ArgumentsBuilderBase<MarketsResolvedValues?, QueryRootMarketsResolvedValuesArgumentsBuilder>
    {
        protected override QueryRootMarketsResolvedValuesArgumentsBuilder Self => this;

        public QueryRootMarketsResolvedValuesArgumentsBuilder(IQuery<MarketsResolvedValues?> query) : base(query)
        {
        }

        public QueryRootMarketsResolvedValuesArgumentsBuilder BuyerSignal(BuyerSignalInput? buyerSignal)
        {
            base.InnerQuery.AddArgument("buyerSignal", buyerSignal);
            return this;
        }
    }
}