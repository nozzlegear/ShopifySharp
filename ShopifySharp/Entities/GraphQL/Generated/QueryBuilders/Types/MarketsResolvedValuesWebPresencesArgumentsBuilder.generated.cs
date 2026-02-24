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
    public sealed class MarketsResolvedValuesWebPresencesArgumentsBuilder : ArgumentsBuilderBase<MarketWebPresenceConnection?, MarketsResolvedValuesWebPresencesArgumentsBuilder>
    {
        protected override MarketsResolvedValuesWebPresencesArgumentsBuilder Self => this;

        public MarketsResolvedValuesWebPresencesArgumentsBuilder(IQuery<MarketWebPresenceConnection?> query) : base(query)
        {
        }

        public MarketsResolvedValuesWebPresencesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MarketsResolvedValuesWebPresencesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MarketsResolvedValuesWebPresencesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MarketsResolvedValuesWebPresencesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MarketsResolvedValuesWebPresencesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}