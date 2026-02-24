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
    public sealed class PriceListQuantityRulesArgumentsBuilder : ArgumentsBuilderBase<QuantityRuleConnection?, PriceListQuantityRulesArgumentsBuilder>
    {
        protected override PriceListQuantityRulesArgumentsBuilder Self => this;

        public PriceListQuantityRulesArgumentsBuilder(IQuery<QuantityRuleConnection?> query) : base(query)
        {
        }

        public PriceListQuantityRulesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceListQuantityRulesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceListQuantityRulesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceListQuantityRulesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceListQuantityRulesArgumentsBuilder OriginType(QuantityRuleOriginType? originType)
        {
            base.InnerQuery.AddArgument("originType", originType);
            return this;
        }

        public PriceListQuantityRulesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}