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
    public sealed class PriceListPriceQuantityPriceBreaksArgumentsBuilder : ArgumentsBuilderBase<QuantityPriceBreakConnection?, PriceListPriceQuantityPriceBreaksArgumentsBuilder>
    {
        protected override PriceListPriceQuantityPriceBreaksArgumentsBuilder Self => this;

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder(IQuery<QuantityPriceBreakConnection?> query) : base(query)
        {
        }

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksArgumentsBuilder SortKey(QuantityPriceBreakSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}